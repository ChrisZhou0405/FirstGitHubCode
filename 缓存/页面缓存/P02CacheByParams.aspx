<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P02CacheByParams.aspx.cs" Inherits="缓存.页面缓存.P02CacheByParams" %>

<%@ OutputCache Duration="60"  VaryByParam="id" %>
<%-- 告诉服务器，当前页面的缓存时间是60S，并且缓存以id作为标识来缓存 --%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <%=DateTime.Now %>
</body>
</html>
