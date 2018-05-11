打包和构建
====================

IdentityServer 由多个 nuget 软件包组成的。

IdentityServer4
^^^^^^^^^^^^^^^
`nuget <https://www.nuget.org/packages/IdentityServer4/>`_ | `github <https://github.com/identityserver/IdentityServer4>`_

包含 IdentityServer 核心对象模型，服务和中间件。只包含对内存配置和用户存储的支持  - 但是你可以通过配置为其他商店的插件提供支持。这就是关于其他 repos 和 packages 的内容。

快速入门 UI
^^^^^^^^^^^^^
`github <https://github.com/IdentityServer/IdentityServer4.Quickstart.UI>`_

一个简单的包含登录、注销和授权页面的初学者用户界面：。

访问令牌验证处理器
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
`nuget <https://www.nuget.org/packages/IdentityServer4.AccessTokenValidation>`_ | `github <https://github.com/IdentityServer/IdentityServer4.AccessTokenValidation>`_

用于在 API 中验证令牌的 ASP.NET Core 身份验证处理程序。 处理程序允许在同一 API 中支持JWT和引用令牌。

ASP.NET Core Identity
^^^^^^^^^^^^^^^^^^^^^
`nuget <https://www.nuget.org/packages/IdentityServer4.AspNetIdentity>`_ | `github <https://github.com/IdentityServer/IdentityServer4.AspNetIdentity>`_

用于 IdentityServer 的 ASP.NET Core Identity 集成包。 该软件包提供了一个简单的配置 API 来让 IdentityServer 用户使用ASP.NET Identity 管理库。

EntityFramework Core
^^^^^^^^^^^^^^^^^^^^
`nuget <https://www.nuget.org/packages/IdentityServer4.EntityFramework>`_ | `github <https://github.com/IdentityServer/IdentityServer4.EntityFramework>`_

IdentityServer 的 EntityFramework Core 存储实现。 该软件包为 IdentityServer 中的配置和操作存储提供 EntityFramework 实现。

开发构建
^^^^^^^^^^
另外我们发布 dev/interim builds 到 MyGet。如果你想尝试一下，请把以下路径添加到 Visual Studio 中：

https://www.myget.org/F/identity/
