欢迎来到 IdentityServer4
==========================

.. image:: images/logo.png
   :align: center

IdentityServer4 是一款包含和实现了 OpenID Connect 和 OAuth 2.0 协议的，适用于 ASP.NET Core 的框架 。

它可以在您的应用程序中启用以下功能： 

作为服务的身份验证
^^^^^^^^^^^^^^^^^^^^^^^^^^^
集中控制你的所有应用 (web, native, mobile, services) 的登录逻辑和工作流。
IdentityServer 是一个 OpenID Connect `官方认证 <https://openid.net/certification/>`_ 的 OpenID Connect 协议的实现。

单点登录/登出
^^^^^^^^^^^^^^^^^^^^^^^^^
在多种类型的应用程序上单点登录 (登出) 。

APIs 访问控制
^^^^^^^^^^^^^^^^^^^^^^^
为各种类型的客户机发放 API 访问令牌，例如：服务器到服务器，Web应用程序，SPA和原生/移动应用程序。

联合网关
^^^^^^^^^^^^^^^^^^
支持 Azure Active Directory, Google, Facebook 等第三方登陆。
这样就隐藏了让您的应用程序连接到第三方登陆验证的实现细节，方便您快速实现第三方登陆验证。

聚焦定制
^^^^^^^^^^^^^^^^^^^^^^
最重要的部分 - IdentityServer 的许多方面可以被定制以适应**您**的需求。
因为 IdentityServer 是一个框架，而不是一个盒装产品或一个 SaaS，您可以编写代码来调整框架，使其适用于您的使用场景。

成熟的开源
^^^^^^^^^^^^^^^^^^
IdentityServer 使用自由的 `Apache 2 <https://www.apache.org/licenses/LICENSE-2.0>`_ 许可，允许在其之上构建商业产品。 
它也是提供维护（provides governance）和法律支持的 `.NET Foundation <https://dotnetfoundation.org/>`_ 的一部分。

免费和商业支持
^^^^^^^^^^^^^^^^^^^^^^^^^^^
如果您需要在建立和运行你的身份验证平台上得到帮助， :ref:`请告诉我们 <refSupport>`.
有多种方法可以帮助到您。

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Introduction

   intro/big_picture
   intro/architecture
   intro/terminology
   intro/specs
   intro/packaging
   intro/support
   intro/test
   intro/contributing

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Quickstarts

   quickstarts/0_overview
   quickstarts/1_client_credentials
   quickstarts/2_resource_owner_passwords
   quickstarts/3_interactive_login
   quickstarts/4_external_authentication
   quickstarts/5_hybrid_and_api_access
   quickstarts/6_aspnet_identity
   quickstarts/7_javascript_client
   quickstarts/8_entity_framework
   quickstarts/community

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Configuration

   configuration/startup
   configuration/resources
   configuration/clients
   configuration/mvc
   configuration/apis

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Topics

   topics/startup
   topics/resources
   topics/clients
   topics/signin
   topics/signin_external_providers
   topics/windows
   topics/signout
   topics/signout_external_providers
   topics/signout_federated
   topics/federation_gateway
   topics/consent
   topics/apis
   topics/deployment
   topics/logging
   topics/events
   topics/crypto
   topics/grant_types
   topics/secrets
   topics/extension_grants
   topics/resource_owner
   topics/refresh_tokens
   topics/reference_tokens
   topics/cors
   topics/discovery
   topics/add_apis
   topics/add_protocols
   topics/tools

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Endpoints

   endpoints/discovery
   endpoints/authorize
   endpoints/token
   endpoints/userinfo
   endpoints/introspection
   endpoints/revocation
   endpoints/endsession

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Reference

   reference/identity_resource
   reference/api_resource
   reference/client
   reference/grant_validation_result
   reference/profileservice
   reference/interactionservice
   reference/options
   reference/ef
   reference/aspnet_identity

.. toctree::
   :maxdepth: 2
   :hidden:
   :caption: Misc

   misc/training
   misc/blogs
   misc/videos
