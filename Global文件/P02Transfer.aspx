<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P02Transfer.aspx.cs" Inherits="Global文件.P02Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%
            string path = Server.MapPath("../../P01Index.aspx");
            Response.Write(path);
            Server.Transfer("");//不能跳转到网站之外的页面上去。
        %>
    </form>
</body>
</html>
