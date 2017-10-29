<%@ Page Language="C#" AutoEventWireup="true" CodeFile="findPwd.aspx.cs" Inherits="findPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        div {
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="step_1" runat="server" visible="true">
    <h2>找回密码</h2>
        <hr />
        请输入要找回密码的用户名：<br />
        <asp:TextBox ID="findName" runat="server"></asp:TextBox><br />
        <asp:Button ID="confirmName" runat="server" Text="确定" OnClick="confirmName_Click" />
        <asp:Button ID="cancelFind" runat="server" Text="取消" OnClick="cancelFind_Click" />
    </div>
    <div id="step_2" runat="server" visible="false">
        请回答下列密保问题：<br />
        Q1:<asp:TextBox ID="question1" runat="server"></asp:TextBox><br />
        答案：<asp:TextBox ID="answer1" runat="server"></asp:TextBox><br />
        Q2:<asp:TextBox ID="question2" runat="server"></asp:TextBox><br />
        答案：<asp:TextBox ID="answer2" runat="server"></asp:TextBox><br />
        Q3:<asp:TextBox ID="question3" runat="server"></asp:TextBox><br />
        答案：<asp:TextBox ID="answer3" runat="server"></asp:TextBox><br />
        <asp:Button ID="confirmFinding" runat="server" Text="确定" OnClick="confirmFinding_Click" />
        <asp:Button ID="cancelFinding" runat="server" Text="取消" OnClick="cancelFinding_Click" />
    </div>
    <div id="step_3" runat="server" visible="false">
        请输入新密码：<br />
        <asp:TextBox ID="newPassword" runat="server"></asp:TextBox><br />
        请再次确认新密码：<br />
        <asp:TextBox ID="newPassword2" runat="server"></asp:TextBox><br />
        <asp:Button ID="confirmChange" runat="server" Text="确认修改" OnClick="confirmChange_Click" />
        <asp:Button ID="cancelChange" runat="server" Text="取消修改" OnClick="cancelChange_Click" />
    </div>
    </form>
</body>
</html>
