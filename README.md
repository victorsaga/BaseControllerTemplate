# BaseControllerTemplate
.Net 4.6.1 Web API 繼承abstract BaseController，並且子Controller可自訂Controller的RoutePrefix

修改 App_Start\WebApiConfig.cs
1.config.MapHttpAttributeRoutes() 參數加入new CustomDirectRouteProvider() → config.MapHttpAttributeRoutes(new CustomDirectRouteProvider())
2.新增class CustomDirectRouteProvider


參考 https://codeday.me/bug/20170815/59027.html

   