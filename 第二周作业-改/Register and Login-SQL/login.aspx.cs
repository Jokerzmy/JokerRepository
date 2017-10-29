using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register_SQL : System.Web.UI.Page
{
    static UserOp us = new UserOp();
    static string str = @"server=(localdb)\v11.0;Integrated Security=SSPI;database=Demo;";
    protected void Page_Load(object sender, EventArgs e)                
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)               //确认登录
    {
        string userName = loginName.Text;
        string password = loginPwd.Text;
        Session["loginName"] = userName;
        int flag;
        flag = us.checkUser(userName, password);
        if(flag == 1)
            Response.Write("<script>alert('登录成功！');location='loginSuccess.aspx'</script>");
        else
            Response.Write("<script>alert('用户名或密码错误！');</script>");
    }
}