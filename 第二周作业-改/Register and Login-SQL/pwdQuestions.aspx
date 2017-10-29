<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pwdQuestions.aspx.cs" Inherits="pwdQuestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>密保问题</h2>
        <hr />
        为了您账号的安全，请设置您的密保问题：
        <br />
        <br />
        问题1：<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True">您父亲的姓名是？</asp:ListItem>
            <asp:ListItem>您母亲的姓名是？</asp:ListItem>
            <asp:ListItem>您配偶的姓名是？</asp:ListItem>
            <asp:ListItem>您小学班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您初中班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您高中班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您大学班主任的姓名是？</asp:ListItem>
            </asp:DropDownList>
        <br />
        <br />
        答案：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <br />
        <br />
        问题2：<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>您父亲的姓名是？</asp:ListItem>
            <asp:ListItem Selected="True">您母亲的姓名是？</asp:ListItem>
            <asp:ListItem>您配偶的姓名是？</asp:ListItem>
            <asp:ListItem>您小学班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您初中班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您高中班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您大学班主任的姓名是？</asp:ListItem>
            </asp:DropDownList>
        <br />
        <br />
        答案：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         <br />
        <br />
        问题3：<asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>您父亲的姓名是？</asp:ListItem>
            <asp:ListItem>您母亲的姓名是？</asp:ListItem>
            <asp:ListItem Selected="True">您配偶的姓名是？</asp:ListItem>
            <asp:ListItem>您小学班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您初中班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您高中班主任的姓名是？</asp:ListItem>
            <asp:ListItem>您大学班主任的姓名是？</asp:ListItem>
            </asp:DropDownList>
        <br />
        <br />
        答案：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="confirmSetting" runat="server" Text="确认设置" OnClick="confirmSetting_Click" />
        <asp:Button ID="cancelSetting" runat="server" Text="取消设置" OnClick="cancelSetting_Click" />
    </div>
    </form>
</body>
</html>
