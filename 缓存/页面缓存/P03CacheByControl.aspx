<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P03CacheByControl.aspx.cs" Inherits="缓存.页面缓存.P03CacheByControl" %>

<%@ OutputCache Duration="10" VaryByControl="DropDownList1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>

<body>
    <form id="f1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
            <asp:ListItem Text="男" Value="0"></asp:ListItem>
            <asp:ListItem Text="女" Value="1"></asp:ListItem>
        </asp:DropDownList>

        <%=DateTime.Now %>
    </form>
</body>
</html>
