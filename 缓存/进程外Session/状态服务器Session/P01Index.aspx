<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P01Index.aspx.cs" Inherits="缓存.进程外Session.状态服务器Session.P01Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form method="post">
        <table>
            <tr>
                <th>用户名：</th>
                <td>
                    <input type="text" name="name" value="admin" /></td>
            </tr>
            <tr>
                <th>密码：</th>
                <td>
                    <input type="text" name="pwd" value="123" /></td>
            </tr>
            <tr>
                <th></th>
                <td>
                    <input type="submit" value="登录" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
