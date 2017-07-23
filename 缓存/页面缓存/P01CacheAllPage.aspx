<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P01CacheAllPage.aspx.cs" Inherits="缓存.页面缓存.P01CacheAllPage" %>

<%@ OutputCache Duration="5" VaryByParam="none" %>
<%-- 告诉服务器当前页面要进行缓存，缓存时间为5秒 --%>

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
