.. _refResosurceOwnerQuickstart:
使用密码保护 API
=================================

OAuth 2.0 协议允许资源拥有者给客户端密码授权：客户端向令牌服务发送用户密码，以获取代表该用户的访问令牌。

该规范建议仅将“资源所有者密码授予”用于“可信”（或旧版）应用程序。一般来说，当您想验证用户身份并请求访问令牌时，使用交互式流程之一的 OpenID Connect 协议要更好一点。

虽然这么说，但是这种授权类型允许我们将用户的概念引入到我们的快速入门 IdentityServer 中，这就是我们展示它的原因。

添加用户
^^^^^^^^^^^^
就像资源（又称作用域）和客户端使用内存存储一样，用户也是这么存储的。

.. note:: 有关如何正确存储和管理用户帐户的更多信息，请查看基于 ASP.NET Identity 的快速入门。

``TestUser`` 类表示测试用户及其声明。让我们通过将以下代码添加到我们的配置类来创建几个用户：

首先将以下 using 引用申明添加到 ``Config.cs`` 文件::

    using IdentityServer4.Test;

    public static List<TestUser> GetUsers()
    {
        return new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "1",
                Username = "alice",
                Password = "password"
            },
            new TestUser
            {
                SubjectId = "2",
                Username = "bob",
                Password = "password"
            }
        };
    }

然后通过 IdentityServer 注册测试用户::

    public void ConfigureServices(IServiceCollection services)
    {
        // configure identity server with in-memory stores, keys, clients and scopes
        services.AddIdentityServer()
            .AddDeveloperSigningCredential()
            .AddInMemoryApiResources(Config.GetApiResources())
            .AddInMemoryClients(Config.GetClients())
            .AddTestUsers(Config.GetUsers());
    }

``AddTestUsers`` 扩展方法在底层做了几件事情

* 增加了对资源所有者密码授权的支持
* 增加对用户相关服务的支持，通常由登录UI使用 (我们将在下一个 quickstart 示例中使用它)
* 增加了基于配置文件获取测试用户信息的服务支持 (在下一个 quickstart 示例中您将学到更多关于用户信息文件配置方面的知识)

增加了资源所有者授权客户端密码访问的支持（密码授权访问）
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
您可以通过改变 ``AllowedGrantTypes`` 属性来简单地为现有客户添加对 grant 类型的支持。 如果您需要您的客户端能够完全支持所有授权类型。

通常，您希望为资源所有者用例创建一个单独的客户端，请将以下内容添加到您的客户端配置::

    public static IEnumerable<Client> GetClients()
    {
        return new List<Client>
        {
            // other clients omitted...

            // resource owner password grant client
            new Client
            {
                ClientId = "ro.client",
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes = { "api1" }
            }
        };
    }

使用密码授权请求令牌
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
客户端看起来非常类似于我们为客户凭证授权所做的工作。主要的区别在于，客户端会以某种方式收集用户的密码，并在令牌请求期间将其发送给令牌服务。

因此 IdentityModel 的 ``TokenClient`` 可以提供帮助::

    // request token
    var tokenClient = new TokenClient(disco.TokenEndpoint, "ro.client", "secret");
    var tokenResponse = await tokenClient.RequestResourceOwnerPasswordAsync("alice", "password", "api1");

    if (tokenResponse.IsError)
    {
        Console.WriteLine(tokenResponse.Error);
        return;
    }

    Console.WriteLine(tokenResponse.Json);
    Console.WriteLine("\n\n");

当您将令牌发送到identity API端点时，您将注意到一个小的但与客户端证书授权相比有着重要的不同。访问令牌将
包含一个 ``sub`` 声明，它能够惟一地标识用户。这个 "sub"  声明可以通过在调用API之后检查内容变量来查看，也可以通过控制台应用程序显示在屏幕上。

``sub`` 声明的存在（或不存在）使 API 在调用时区分是客户端调用还是用户调用。
