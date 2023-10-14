const { readFileSync, writeFileSync } = require('node:fs')

const data = readFileSync('./tg_api_pretty.json')
const json = JSON.parse(data)
const models = json.models


const primitives = {
    bool: 'bool',
    int: 'long', //bit unefficient, will be fixed later
    str: 'string',
    float: 'float'
}

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
            final = `${getType(type[0][1])}[]`
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
        let inheritance = ''
        inheritance = model.name.includes('ChatMember') ? ': ChatMember' : ''
        inheritance = (model.name.includes('Input') && model.name.includes('MessageContent')) ? ': InputMessageContent' : ''

        final += `using TeleSharpX.Types;
using System.Text.Json.Serialization;
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
            final += `\n\t\t[JsonPropertyName("${x.name}")]\n\t\tpublic ${type} ${snakeToPascal(x.name) + (snakeToPascal(model.name) === snakeToPascal(x.name) ? 'T' : '')} { get; set; }`
        })
        final += '\n\t}'
        final += '\n}'
        writeFileSync(`./export/${snakeToPascal(model.name)}.cs`, final)
        console.log(`written ${snakeToPascal(model.name)}.cs`)
    } else {
        final += model[0]
        writeFileSync(`./export/${model[1]}.cs`, final)
        console.log(`written custom ${model[1]}.cs`)
    }

    
}

models.forEach(x => {
    try {
        generateCSharpType(x)
    } catch (ex) {
        console.error(`Failed proccessing of ${x.name}\n${ex}`)
    }
})
generateCSharpType([`using TeleSharpX.Types;
using System.Text.Json.Serialization;
using System;

namespace TeleSharpX.Types
{
    public enum ChatMemberStatus
    {
        Creator,
        Administrator,
        Member,
        Restricted,
        Kicked
    }
    public class ChatMember
    {
        [JsonPropertyName("status")]
        internal string StringStatus { get; set; }

        public ChatMemberStatus Status => Enum.Parse<ChatMemberStatus>(StringStatus, true);
    }
}
`, 'ChatMember'])

generateCSharpType([`using TeleSharpX.Types;

namespace TeleSharpX.Types
{
    public abstract class InputMessageContent
    {
    
    }
}
`, 'InputMessageContent'])