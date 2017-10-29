<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changePwd.aspx.cs" Inherits="changePwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="step1_check" runat="server">
    <h2>修改密码</h2>
        <hr />
        请输入要修改密码的用户名：<br />
        <asp:TextBox ID="changeName" runat="server"></asp:TextBox><br />
        请输入原密码：<br />
        <asp:TextBox ID="originalPwd" runat="server"></asp:TextBox><br />
        <asp:Button ID="confirmInfo" runat="server" Text="确定" OnClick="confirmInfo_Click" />
        <asp:Button ID="cancelInfo" runat="server" Text="取消" OnClick="cancelInfo_Click" />
    </div>
    <div id="step2_change" runat="server" visible="false">
        请输入新密码：<br />
        <asp:TextBox ID="newPassword" runat="server"></asp:TextBox><br />
        请再次确认新密码：<br />
        <asp:TextBox ID="newPassword2" runat="server"></asp:TextBox><br />
        <asp:Button ID="confirmChange" runat="server" Text="确认修改" OnClick="btnChange_Click" />
        <asp:Button ID="cancelChange" runat="server" Text="取消修改" OnClick="cancelChange_Click" />
    </div>
    </form>
</body>
</html>
