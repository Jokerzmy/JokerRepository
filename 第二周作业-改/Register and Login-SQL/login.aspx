<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Register_SQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图书管理系统登陆与注册-连接数据库</title>
    <style>
        div {
            text-align:center;
        }
        p {
            text-align:center;
            font-size:small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>欢迎进入图书管理系统！</p>
        <hr />
    <div id="login">
        <h2>用户登录</h2>
        <hr />
        用户名：<br />
        <asp:TextBox ID="loginName" runat="server"></asp:TextBox><br />
        密码：<br />
        <asp:TextBox ID="loginPwd" runat="server" TextMode="Password"></asp:TextBox><br />
        <p><a href="findPwd.aspx">忘记密码？</a> <a href="changePwd.aspx">修改密码</a><br /><br />
        <a href="register.aspx">没有账号？点我注册</a><br /></p>
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click"/>
    </div>
    </form>
</body>
</html>
