## 关于 IdentityServer4
[<img align="right" width="100px" src="https://dotnetfoundation.org/images/logo_big.svg" />](https://dotnetfoundation.org/projects?q=identityserver&type=project)

IdentityServer 是一款免费、开源的，并包含和实现了 [OpenID Connect](http://openid.net/connect/) 和 [OAuth 2.0](https://tools.ietf.org/html/rfc6749) 协议的，适用于 ASP.NET Core 的框架 。
IdentityServer4 由 [Dominick Baier](https://twitter.com/leastprivilege) 和 [Brock Allen](https://twitter.com/brocklallen)创建和维护， 它包含了在应用程序中集成基于令牌的身份验证、单点登录和API访问控制所需的所有协议实现和扩展点。
IdentityServer4 是由 [OpenID Foundation](https://openid.net) 正式 [认证](https://openid.net/certification/) 因此符合规范并可互操作。
它是 [.NET Foundation](https://www.dotnetfoundation.org/) 的一部分，并在其 [行为准则](https://www.dotnetfoundation.org/code-of-conduct) 下运行。 它在 [Apache 2](https://opensource.org/licenses/Apache-2.0) （OSI批准的许可证）下获得许可。

有关项目文件，请访问 [readthedocs](https://identityserver4.readthedocs.io).

## Overview
IdentityServer4 consists of multiple repositories (in addition to this repository):

* [Samples](https://github.com/IdentityServer/IdentityServer4.Samples)
* [Access token validation handler for ASP.NET Core](https://github.com/IdentityServer/IdentityServer4.AccessTokenValidation)
* [Quickstart UI](https://github.com/IdentityServer/IdentityServer4.Quickstart.UI)
* [ASP.NET Identity integration](https://github.com/IdentityServer/IdentityServer4.AspNetIdentity)
* [EntityFramework integration](https://github.com/IdentityServer/IdentityServer4.EntityFramework)

If you encounter issues or find bugs, please open an issue in this repo here first.

## How to build
IdentityServer is built against the latest ASP.NET Core 2.

* [Install](https://www.microsoft.com/net/download/core#/current) the latest .NET Core 2 SDK
* Run `build.ps1` (Powershell) or `build.sh` (bash)

## ASP.NET Core 1.x
For using IdentityServer with ASP.NET Core 1.x, you can use the 1.x packages of IdentityServer and [this branch](https://github.com/IdentityServer/IdentityServer4/tree/aspnetcore1). Documentation for 1.x can be found [here](http://docs.identityserver.io/en/aspnetcore1/). The 1.x version is not maintained anymore.

## Commercial and Community Support
If you need help with implementing IdentityServer4 or your security architecture in general, there are both free and commercial support options.
See [here](https://identityserver4.readthedocs.io/en/release/intro/support.html) for more details.

## Sponsorship
If you are a fan of the project or a company that relies on IdentityServer, you might want to consider sponsoring.
This will help us devote more time to answering questions and doing feature development. If you are interested please head to our [Patreon](https://www.patreon.com/identityserver) page which has further details.

## Current corporate sponsors

[Thinktecture AG](https://www.thinktecture.com)  
[Ritter Insurance Marketing](https://www.ritterim.com)  

You can see a list of our current sponsors [here](https://github.com/IdentityServer/IdentityServer4/blob/release/SPONSORS.md) - and for companies we have some nice advertisement options as well.

## Acknowledgements
IdentityServer4 is built using the following great open source projects

* [ASP.NET Core](https://github.com/aspnet)
* [Json.Net](http://www.newtonsoft.com/json)
* [Cake](http://cakebuild.net/)
* [XUnit](https://xunit.github.io/)
* [Fluent Assertions](http://www.fluentassertions.com/)

..and last but not least a big thanks to all our [contributors](https://github.com/IdentityServer/IdentityServer4/graphs/contributors)!
