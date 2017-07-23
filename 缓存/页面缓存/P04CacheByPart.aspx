<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P04CacheByPart.aspx.cs" Inherits="缓存.页面缓存.P04CacheByPart" %>

<%@ Register Src="~/页面缓存/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
        <%=DateTime.Now %>
    </form>
</body>
</html>
