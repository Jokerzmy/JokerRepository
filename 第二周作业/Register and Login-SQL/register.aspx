<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="step_1" runat="server" visible="true">
    <h2>用户注册</h2>
        <hr />
        请输入用户名：<br />
        <asp:TextBox ID="registerName" runat="server"></asp:TextBox>（用户名长度不能超过10个字符，不能为空，不能含有空格！）<br />
        请输入密码：<br />
        <asp:TextBox ID="registerPwd" runat="server" TextMode="Password"></asp:TextBox>（密码长度在6-24个字符之间，不能为空，不能含有空格！）<br />
        请再次确认密码：<br />
        <asp:TextBox ID="confirmRegisterPwd" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="btnRegister" runat="server" Text="确认注册" OnClick="btnRegister_Click" />
        <asp:Button ID="btnCancelRegister" runat="server" Text="取消注册" OnClick="btnCancelRegister_Click" />
    </div>
    <div>

    </div>
    </form>
</body>
</html>
