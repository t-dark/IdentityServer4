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

Adding a client for the resource owner password grant
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
You could simply add support for the grant type to our existing client by changing the
``AllowedGrantTypes`` property. If you need your client to be able to use both grant types
that is absolutely supported.

Typically you want to create a separate client for the resource owner use case,
add the following to your clients configuration::

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

Requesting a token using the password grant
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
The client looks very similar to what we did for the client credentials grant.
The main difference is now that the client would collect the user's password somehow,
and send it to the token service during the token request.

Again IdentityModel's ``TokenClient`` can help out here::

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

When you send the token to the identity API endpoint, you will notice one small
but important difference compared to the client credentials grant. The access token will
now contain a ``sub`` claim which uniquely identifies the user. This "sub" claim can be seen by examining the content variable after the call to the API and also will be displayed on the screen by the console application.

The presence (or absence) of the ``sub`` claim lets the API distinguish between calls on behalf
of clients and calls on behalf of users.
