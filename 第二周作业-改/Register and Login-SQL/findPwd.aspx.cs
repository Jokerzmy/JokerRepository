using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class findPwd : System.Web.UI.Page
{
    static string str = @"server=LAPTOP-M4BAVOQS;Integrated Security=SSPI;database=database;";
    static UserOp us = new UserOp();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void confirmFinding_Click(object sender, EventArgs e)             //提交密保问题答案，确认找回密码
    {
        string userName = Session["findName"].ToString();
        string a1 = answer1.Text;
        string a2 = answer2.Text;
        string a3 = answer3.Text;
        int flag1 = us.checkAnswer1(a1, userName);
        int flag2 = us.checkAnswer2(a2, userName);
        int flag3 = us.checkAnswer3(a3, userName);
        if(flag1 == 1 && flag2 == 1 && flag3 == 1)
        {
            Response.Write("<script>alert('密码已找回！请立即修改新密码！');</script>");
            step_1.Visible = false;
            step_2.Visible = false;
            step_3.Visible = true;
        }
        else
            Response.Write("<script>alert('答案错误！');</script>");
    }

    protected void cancelFinding_Click(object sender, EventArgs e)              //取消找回
    {
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }

    protected void confirmChange_Click(object sender, EventArgs e)              //修改密码
    {
        string userName = Session["findName"].ToString();
        string password = newPassword.Text;
        string newpassword = newPassword.Text;
        string newpassword2 = newPassword2.Text;
        if (newpassword == newpassword2)
        {
            us.changePwd(userName, password);
            Response.Write("<script>alert('修改成功！');location='login.aspx'</script>");
        }
        else
            Response.Write("<script>alert('两次输入的密码不一致！');</script>");
    }

    protected void cancelChange_Click(object sender, EventArgs e)               //取消找回
    {
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }

    protected void confirmName_Click(object sender, EventArgs e)                //确定
    {
        step_2.Visible = true;
        string userName = findName.Text;
        Session["findName"] = userName;
        question1.Text = us.q1(userName);
        question2.Text = us.q2(userName);
        question3.Text = us.q3(userName);
    }

    protected void cancelFind_Click(object sender, EventArgs e)             //取消找回
    {
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }
}