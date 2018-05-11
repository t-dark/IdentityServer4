整体情况
===============

大多数现代应用程序看起来或多或少像这样：

.. image:: images/appArch.png

最常见的交互是：

* 浏览器与 Web 应用程序进行通信

* Web 应用程序与 Web API 进行通信（有时是Web应用程序自己发起，有时代表用户发起）

* 基于浏览器的应用程序与 Web API 进行通信

* 本机应用程序与Web API进行通信

* 基于服务器的应用程序与Web API进行通信

* Web API与Web API进行通信（有时是他们自己发起，有时代表用户发起）

通常，每个层（前端、中间层和后端）都必须保护资源并实现身份验证/或授权——通常是针对同一用户存储。

将这些基本安全功能外包给安全令牌服务，可防止在这些应用程序和端点之间复制该功能。

重构应用程序以支持安全令牌服务，会演变成以下体系结构和协议：

.. image:: images/protocols.png

这样的设计将安全问题分为两部分：

Authentication
^^^^^^^^^^^^^^
Authentication is needed when an application needs to know the identity of the current user.
Typically these applications manage data on behalf of that user and need to make sure that this user can only
access the data for which he is allowed. The most common example for that is (classic) web applications –
but native and JS-based applications also have a need for authentication.

The most common authentication protocols are SAML2p, WS-Federation and OpenID Connect – SAML2p being the
most popular and the most widely deployed.

OpenID Connect is the newest of the three, but is considered to be the future because it has the
most potential for modern applications. It was built for mobile application scenarios right from the start
and is designed to be API friendly.

API Access
^^^^^^^^^^
Applications have two fundamental ways with which they communicate with APIs – using the application identity,
or delegating the user’s identity. Sometimes both methods need to be combined.

OAuth2 is a protocol that allows applications to request access tokens from a security token service and use them
to communicate with APIs. This delegation reduces complexity in both the client applications as well as the APIs since
authentication and authorization can be centralized.

OpenID Connect and OAuth 2.0 – better together
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
OpenID Connect and OAuth 2.0 are very similar – in fact OpenID Connect is an extension on top of OAuth 2.0.
The two fundamental security concerns, authentication and API access, are combined into a  single protocol - often with a single round trip to the security token service. 

We believe that the combination of OpenID Connect and OAuth 2.0 is the best approach to secure modern
applications for the foreseeable future. IdentityServer4 is an implementation of these two protocols and is
highly optimized to solve the typical security problems of today’s mobile, native and web applications.

How IdentityServer4 can help
^^^^^^^^^^^^^^^^^^^^^^^^^^^^
IdentityServer is middleware that adds the spec compliant OpenID Connect and OAuth 2.0 endpoints to an arbitrary ASP.NET Core application.

Typically, you build (or re-use) an application that contains a login and logout page (and maybe consent - depending on your needs),
and the IdentityServer middleware adds the necessary protocol heads to it, so that client applications can talk to it using those standard protocols.

.. image:: images/middleware.png

The hosting application can be as complex as you want, but we typically recommend to keep the attack surface as small as possible by including
authentication related UI only.
