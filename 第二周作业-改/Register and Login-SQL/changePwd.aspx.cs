using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changePwd : System.Web.UI.Page
{
    static UserOp us = new UserOp();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChange_Click(object sender, EventArgs e)              //确认修改密码
    {
        string userName = changeName.Text;
        string password = newPassword.Text;
        string newpassword = newPassword.Text;
        string newpassword2 = newPassword2.Text;
        if(newpassword == newpassword2)
        {
            if(us.changeJudge(newpassword) == 1)
            {
                us.changePwd(userName, password);
                Response.Write("<script>alert('修改成功！');location='login.aspx'</script>");
            }
            else
                Response.Write("<script>alert('密码不能含有空格且不能为空！');</script>");
        }
        else
            Response.Write("<script>alert('两次输入的密码不一致！');</script>");
    }

    protected void cancelChange_Click(object sender, EventArgs e)               //取消修改密码
    {
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }

    protected void confirmInfo_Click(object sender, EventArgs e)                //修改密码-确认信息核对
    {
        string userName = changeName.Text;
        string password = originalPwd.Text;
        int flag;
        flag = us.checkUser(userName, password);
        if (flag == 1)
        {
            Response.Write("<script>alert('身份验证成功！');</script>");
            step2_change.Visible = true;
        }
        else
            Response.Write("<script>alert('用户名或密码错误！');</script>");
    }

    protected void cancelInfo_Click(object sender, EventArgs e)             //取消修改密码
    {
        Response.Write("<script>alert('操作取消！');location='login.aspx'</script>");
    }
}