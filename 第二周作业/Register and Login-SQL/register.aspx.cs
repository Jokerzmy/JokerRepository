using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//用户注册页面
public partial class register : System.Web.UI.Page
{
    static UserOp us = new UserOp();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)               //确认注册
    {
        string userName = registerName.Text;
        string password = registerPwd.Text;
        string password2 = confirmRegisterPwd.Text;
        if (password == password2)
        {
            int flag = us.registerJudge(userName, password);
            if(flag == 1)
            {
                us.addUsers(userName, password);
                Session["registerName"] = userName;
                Response.Write("<script>alert('注册成功！');location='pwdQuestions.aspx'</script>");
            }
            else
                Response.Write("<script>alert('用户名和密码格式错误！');</script>");
        }
        else
            Response.Write("<script>alert('两次输入的密码不一致！');</script>");
    }

    protected void btnCancelRegister_Click(object sender, EventArgs e)              //取消注册
    {
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }
}