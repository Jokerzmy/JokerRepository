using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pwdQuestions : System.Web.UI.Page
{
    static UserOp us = new UserOp();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void confirmSetting_Click(object sender, EventArgs e)             //确认设置密保问题
    {
        string userName = Session["registerName"].ToString();
        string question1 = DropDownList1.Text;
        string answer1 = TextBox1.Text;
        string question2 = DropDownList1.Text;
        string answer2 = TextBox1.Text;
        string question3 = DropDownList1.Text;
        string answer3 = TextBox1.Text;
        if(us.nullJudge(answer1) == 1 && us.nullJudge(answer2) == 1 && us.nullJudge(answer3) == 1)
        {
            us.addPwdQuestions(userName, question1, answer1, question2, answer2, question3, answer3);
            Response.Write("<script>alert('密保设置成功！');location='login.aspx'</script>");
        }
        else
            Response.Write("<script>alert('答案不能空！');</script>");
    }

    protected void cancelSetting_Click(object sender, EventArgs e)              //取消设置密保问题
    {
        string userName = Session["registerName"].ToString();
        us.deleteUser(userName);
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }
}