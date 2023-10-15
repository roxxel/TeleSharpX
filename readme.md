<br/>
<p align="center">
  <h3 align="center">TeleSharpX</h3>

  <p align="center">
    Modern SDK for Telegram Bot API made for .NET 
    <br/>
    <br/>
    <a href="https://github.com/roxxel/TeleSharpX"><strong>Explore the docs » (soon)</strong></a>
    <br/>
    <br/>
  </p>
</p>

![Contributors](https://img.shields.io/github/contributors/roxxel/TeleSharpX?color=dark-green) ![Forks](https://img.shields.io/github/forks/roxxel/TeleSharpX?style=social) ![Stargazers](https://img.shields.io/github/stars/roxxel/TeleSharpX?style=social) ![Issues](https://img.shields.io/github/issues/roxxel/TeleSharpX) ![License](https://img.shields.io/github/license/roxxel/TeleSharpX) 

## Table Of Contents

* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)

## Getting Started

Library us built for .NET Standard 2.1


### Prerequisites

Install 

* Nuget

```powershell
Install-Package TeleSharpX
```

## Usage

Assuming you have create .NET 7 Console application and installed TeleSharpX package.
Basic echo bot:
```cs
using TeleSharpX;

var client = new TelegramClient(new()
{
    Token = "Bot Token goes here"
})
client.OnMessage += async (s,e) => 
{
    await client.SendMessage(e.From.Id, e.Text);
};
await client.StartPolling(); // this call will block your main thread until `client.StopPolling()` is called


```

## Roadmap

See the [open issues](https://github.com/roxxel/TeleSharpX/issues) for a list of proposed features (and known issues).

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.
* If you have suggestions for adding or removing projects, feel free to [open an issue](https://github.com/roxxel/TeleSharpX/issues/new) to discuss it, or directly create a pull request after you edit the *README.md* file with necessary changes.
* Please make sure you check your spelling and grammar.
* Create individual PR for each suggestion.
* Please also read through the [Code Of Conduct (soon)](https://github.com/roxxel/TeleSharpX/blob/main/CODE_OF_CONDUCT.md) before posting your first idea as well.

### Creating A Pull Request

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See [LICENSE](https://github.com/roxxel/TeleSharpX/blob/main/LICENSE.md) for more information.
