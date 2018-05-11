## 关于 IdentityServer4
[<img align="right" width="100px" src="https://dotnetfoundation.org/images/logo_big.svg" />](https://dotnetfoundation.org/projects?q=identityserver&type=project)

IdentityServer 是一款免费、开源的，并包含和实现了 [OpenID Connect](http://openid.net/connect/) 和 [OAuth 2.0](https://tools.ietf.org/html/rfc6749) 协议的，适用于 ASP.NET Core 的框架 。
IdentityServer4 由 [Dominick Baier](https://twitter.com/leastprivilege) 和 [Brock Allen](https://twitter.com/brocklallen)创建和维护， 它包含了在应用程序中集成基于令牌的身份验证、单点登录和API访问控制所需的所有协议实现和扩展点。
IdentityServer4 是由 [OpenID Foundation](https://openid.net) 正式 [认证](https://openid.net/certification/) 因此符合规范并可互操作。
它是 [.NET Foundation](https://www.dotnetfoundation.org/) 的一部分，并在其 [行为准则](https://www.dotnetfoundation.org/code-of-conduct) 下运行。 它在 [Apache 2](https://opensource.org/licenses/Apache-2.0) （OSI批准的许可证）下获得许可。

有关项目文件，请访问 [readthedocs](https://identityserver4.readthedocs.io).

## 概览
IdentityServer4 由多个代码库组成 (除了当前库):

* [例子](https://github.com/IdentityServer/IdentityServer4.Samples)
* [适用于 ASP.NET Core 的访问令牌验证处理程序](https://github.com/IdentityServer/IdentityServer4.AccessTokenValidation)
* [快速入门](https://github.com/IdentityServer/IdentityServer4.Quickstart.UI)
* [集成 ASP.NET Identity](https://github.com/IdentityServer/IdentityServer4.AspNetIdentity)
* [集成 EntityFramework](https://github.com/IdentityServer/IdentityServer4.EntityFramework)

如果您遇到问题或发现错误，请在 issues 面板中 创建一个 issue 并提交。

## 如何构建
IdentityServer 根据最新的 ASP.NET Core 2 构建的。

* [安装](https://www.microsoft.com/net/download/core#/current) 最新的 .NET Core 2 SDK
* 运行 `build.ps1` (Powershell) or `build.sh` (bash)

## ASP.NET Core 1.x
要将 IdentityServer 与 ASP.NET Core 1.x 一起使用，你可以使用 IdentityServer 的 1.x 包和 [这个分支](https://github.com/IdentityServer/IdentityServer4/tree/aspnetcore1).  1.x 的文档可以在 [这里](http://docs.identityserver.io/en/aspnetcore1/)找到.  1.x 版本不再被维护。

## 商业和社区支持
如果你需要实施 IdentityServer4 或一般安全架构方面的帮助，这里有免费和商业支持选项。
详情请看 [这里](https://identityserver4.readthedocs.io/en/release/intro/support.html) 。

## 赞助
如果你是该项目的粉丝或是一个依赖 IdentityServer 的公司，而且你有考虑赞助。
这将有助于我们花更多时间来回答问题并进行功能开发。如果您有兴趣，请前往我们的 [Patreon](https://www.patreon.com/identityserver) 页面了解更多详情。

## 目前的企业赞助商

[Thinktecture AG](https://www.thinktecture.com)  
[Ritter Insurance Marketing](https://www.ritterim.com)  

您可以在 [这里](https://github.com/IdentityServer/IdentityServer4/blob/release/SPONSORS.md)看到我们当前赞助商的名单 - 对于公司来说，我们也有一些不错的广告选项。

## 致谢
IdentityServer4 使用以下伟大的开源项目构建

* [ASP.NET Core](https://github.com/aspnet)
* [Json.Net](http://www.newtonsoft.com/json)
* [Cake](http://cakebuild.net/)
* [XUnit](https://xunit.github.io/)
* [Fluent Assertions](http://www.fluentassertions.com/)

..最后但并非最不重要的一点是非常感谢所有我们的 [贡献者](https://github.com/IdentityServer/IdentityServer4/graphs/contributors)！
