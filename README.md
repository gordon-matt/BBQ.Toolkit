[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=gordon_matt%40live%2ecom&lc=AU&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted)

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/BBQ.Toolkit/Resources/Images/BBQ.png" alt="Logo" width="250" />

# BBQ Toolkit

## Intro
I wrote several tools over the years for doing different things (filtering log files, playing with regular expressions, etc) and some years ago I decided it would be good to keep them all together in one easy toolkit. So I created a Windows Forms app with plugin architecture using MEF and came up with the "BBQ Toolkit". Why BBQ? Why not? I like BBQs.

You can easily add new plugins by simply implementing `IPlugin`, `IUserControlPlugin` or `IFormPlugin` and then also adding the following "Post-build event":

`XCOPY /Y /S "$(TargetDir)*.*" "$(SolutionDir)$(SolutionName)\$(OutDir)Plugins\*.*"`

Look at some of the existing plugins and you'll get the idea.

## Screenshots
Here are screenshots of some of the tools in the kit

**Startup**:

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/_Start.PNG" alt="Startup" />

**Db Schema Browser**:

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/DbSchemaBrowser.PNG" alt="Db Schema Browser" />

**Image Map Editor**:

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/ImageMapEditor.PNG" alt="Image Map Editor" />

**Json Formatter**:

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/JsonFormatter.PNG" alt="Json Formatter" />

**Regex Studio**:

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/RegexStudio.PNG" alt="Regex Studio" />

**Simple Code Generator**:

This is by far my favorite tool in the kit. It lets you use the [Liquid Templating language](https://shopify.github.io/liquid/) to generate code from 3 different sources: CSV files, a simpel list of strings or JSON.

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/SimpleCodeGenerator_Template.PNG" alt="Simple Code Generator - Template" />

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/SimpleCodeGenerator_Results.PNG" alt="Simple Code Generator - Results" />

**XSD Generator**:

<img src="https://github.com/gordon-matt/BBQ.Toolkit/blob/master/_Misc/Screenshots/XsdGenerator.PNG" alt="XSD Generator" />

## License

This project is licensed under the MIT license.

## Donate
If you find this project helpful, consider buying me a cup of coffee.

[![PayPal](https://img.shields.io/badge/PayPal-003087?logo=paypal&logoColor=fff)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=gordon_matt%40live%2ecom&lc=AU&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted)

| Crypto         | Wallet Address |
|----------------|----------------|
| ![Bitcoin](https://img.shields.io/badge/Bitcoin-FF9900?logo=bitcoin&logoColor=white) | 1EeDfbcqoEaz6bbcWsymwPbYv4uyEaZ3Lp |
| ![Ethereum](https://img.shields.io/badge/Ethereum-3C3C3D?logo=ethereum&logoColor=white) | 0x277552efd6ea9ca9052a249e781abf1719ea9414 |
| ![Litecoin](https://img.shields.io/badge/Litecoin-A6A9AA?logo=litecoin&logoColor=white) | LRUP8hukWGXRrcPK6Tm7iUp9vPvnNNt3uz |

<img src="https://komarev.com/ghpvc/?username=gordon-matt&label=GitHub%20Hits%20Since%202025-06-01%3A%20&color=ff0000&style=flat" alt="gordon-matt" />
