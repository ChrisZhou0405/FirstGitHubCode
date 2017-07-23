<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="缓存.页面缓存.WebUserControl1" %>
<%@ OutputCache Duration="10" VaryByParam="none" %>
<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Text="男" Value="0"></asp:ListItem>
    <asp:ListItem Text="女" Value="1"></asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownList2" runat="server">
    <asp:ListItem Text="男" Value="0"></asp:ListItem>
    <asp:ListItem Text="女" Value="1"></asp:ListItem>
</asp:DropDownList>
<%=DateTime.Now %>