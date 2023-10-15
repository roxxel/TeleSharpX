const { readFileSync, writeFileSync } = require('node:fs')

const data = readFileSync('./tg_api_pretty.json')
const json = JSON.parse(data)
const models = json.models

const tabTo4Spaces = (str) => {
    return str.replaceAll("\t", "    ")
}

const primitives = {
    bool: 'bool',
    int: 'long', //bit unefficient, will be fixed later
    str: 'string',
    float: 'float',
    true: 'bool',
    file: 'InputFile',
    false: 'bool'
}

const snakeToCamel = str =>
  str.toLowerCase().replace(/([-_][a-z])/g, group =>
    group
      .toUpperCase()
      .replace('-', '')
      .replace('_', '')
  )
function escapeXml(unsafe) {
    return unsafe.replace(/[<>&'"]/g, function (c) {
        switch (c) {
            case '<': return '&lt;';
            case '>': return '&gt;';
            case '&': return '&amp;';
            case '\'': return '&apos;';
            case '"': return '&quot;';
        }
    });
}
const getType = (type) => {
    const csType = primitives[type[0]]
    let final = ''
    if (typeof csType !== 'undefined') {
        final = type.optional ? csType + "?" : csType
    } else {
        if (type[0][0] === 'array') {
            final = `System.Collections.Generic.IEnumerable<${getType(type[0][1])}>`
        } else {
            final = type[0]
        }
    }
    return final
}

const snakeToPascal = (string) => {
    return string.split("/")
        .map(snake => snake.split("_")
            .map(substr => substr.charAt(0)
                .toUpperCase() +
                substr.slice(1))
            .join(""))
        .join("/");
};

const generateCSharpType = (model) => {
    let final = '//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND\n'
    if (!Array.isArray(model)) {
        if (model.name.includes("BotCommandScope") ||
            model.name.includes("MenuButton") || 
            model.name.includes("InlineQueryResult")) {
            return
        }
        let inheritance = ''
        inheritance += model.name.includes('ChatMember') ? ': ChatMember' : ''
        inheritance += (model.name.includes('Input') && model.name.includes('MessageContent')) ? ': InputMessageContent' : ''
        inheritance += (model.name.includes('InlineQueryResult')) ? ': InlineQueryResult' : ''
        inheritance += (model.name.includes('BotCommandScope')) ? ': BotCommandScope' : ''
        inheritance += (model.name.includes('InputMedia')) ? ': InputMedia' : ''
        inheritance += (model.name.includes('PassportElementError')) ? ': PassportElementError' : ''
        inheritance += (model.name === "InlineKeyboardMarkup" || model.name ===  "ReplyKeyboardMarkup" || model.name ===  "ReplyKeyboardRemove" || model.name === "ForceReply") ? ': ReplyMarkup' : ''


        final += `using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
\tpublic class ${model.name} ${inheritance}\n\t{`

        model.params.forEach(x => {
            if (model.name.includes('ChatMember') && x.name === 'status') {
                return
            }
            const type = getType(x.type)
            final += `\n\t\t/// <summary>\n\t\t/// ${escapeXml(x.description.split('\n').join('\n\t\t/// '))}\n\t\t/// </summary>`
            final += `\n\t\t[JsonProperty("${x.name}")]\n\t\tpublic ${type} ${snakeToPascal(x.name) + (snakeToPascal(model.name) === snakeToPascal(x.name) ? 'T' : '')} { get; set; }`
        })
        final += '\n\t}'
        final += '\n}'
        writeFileSync(`./export/${snakeToPascal(model.name)}.cs`, tabTo4Spaces(final))
        console.log(`written ${snakeToPascal(model.name)}.cs`)
    } else {
        final += model[0]
        writeFileSync(`./export/${model[1]}.cs`, tabTo4Spaces(final))
        console.log(`written custom ${model[1]}.cs`)
    }

    
}

const generateMethod = (method) => {

    const params = []
    method.params.sort((x,y) => Number(x.optional) - Number(y.optional))
    method.params.forEach(p => {
        if (method.name === 'sendMediaGroup' && p.name === 'media') {
            params.push(`System.Collections.Generic.IEnumerable<InputMedia> media`)
            return
        }
        if (p.name === 'parse_mode') {
            params.push(`ParseMode parseMode = ParseMode.MarkdownV2`)
            return
        }
        if (p.name === 'reply_markup') {
            params.push(`ReplyMarkup? replyMarkup = null`)
            return
        }
        params.push(
            `${getType(p.type)}${p.optional ? '?' : ''} ${snakeToCamel(p.name)}` + (p.optional ? ` = null` : '')
        )
    })
    const strParams = params.length > 0 ? `, ${params.join(', ')}` : ''
    let strBody = `Object body = null;`
    if (params.length > 0) 
    {
        strBody = 'var body = new {\n'
        strBody += method.params.map(x => {
            if (x.name === "parse_mode") {
                return '\t\t\tparse_mode = parseMode.ToString()'
            }
            return `\t\t\t${x.name} = ${snakeToCamel(x.name)}`
        }).join(',\n')
        strBody += '\n\t\t};'
    }
    const met = `// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class ${snakeToPascal(method.name)}
{
    /// <summary>
    /// ${escapeXml(method.description.split('\n').join('\n\t\t/// '))}
    ///</summary>
    public static async Task<${getType(method.return)}> ${snakeToPascal(method.name)}Async(this TelegramClient cl${strParams})
    {
        var api = cl._apiClient;
        ${strBody}
        var resp = await api.Send<${getType(method.return)}>("${method.name}", System.Net.Http.HttpMethod.${snakeToPascal(method.type)}, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
`
    writeFileSync(`./methods/${snakeToPascal(method.name)}.cs`, tabTo4Spaces(met))
    console.log(`written ${snakeToPascal(method.name)}.cs`)
}

models.forEach(x => {
    try {
        generateCSharpType(x)
    } catch (ex) {
        console.error(`Failed proccessing of ${x.name}\n${ex}`)
    }
})
json.methods.forEach(x => {
    try {
        generateMethod(x)
    } catch (ex) {
        console.error(`Failed proccessing of ${x.name}\n${ex}`)
    }
})
