using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// UserOp 的摘要说明
/// </summary>
public class UserOp
{
    static string str = @"server=LAPTOP-M4BAVOQS;Integrated Security=SSPI;database=database;";
    public UserOp()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public void addUsers(string userName, string password)              //注册时添加新用户
    {
        string sql = "insert into Users(userName,password) values(N'" + userName + "','" + password + "')";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public void addPwdQuestions(string userName, string q1, string a1, string q2, string a2, string q3, string a3)       //添加密保问题
    {
        string sql = "insert into pwdQuestions(question1,answer1,question2,answer2,question3,answer3,userName) values(N'" + q1 + "',N'" + a1 + "',N'" + q2 + "',N'" + a2 + "',N'" + q3 + "',N'" + a3 + "',N'" + userName + "')";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public int checkUser(string userName, string password)              //核对用户名与密码是否吻合
    {
        string sql = "select * from users where userName = N'" + userName + "' and password = '" + password + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        int count = dt.Rows.Count;
        if (count == 0)
            return -1;
        else
            return 1;
    }
    public void changePwd(string userName, string password)             //修改密码
    {
        string sql = "update Users set password = '" + password + "' where userName = '" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public string q1(string userName)               //返回密保问题1
    {
        string sql = "select question1 from pwdQuestions where userName = N'" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        string q1 = dt.Rows[0][0].ToString();
        return q1;
    }
    public string q2(string userName)               //返回密保问题2
    {
        string sql = "select question2 from pwdQuestions where userName = N'" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        string q2 = dt.Rows[0][0].ToString();
        return q2;
    }
    public string q3(string userName)               //返回密保问题3
    {
        string sql = "select question3 from pwdQuestions where userName = N'" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        string q3 = dt.Rows[0][0].ToString();
        return q3;
    }
    public int checkAnswer1(string a1, string userName)             //验证密保问题1
    {
        string sql = "select answer1 from pwdQuestions where userName = N'" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        int count = dt.Rows.Count;
        if (count == 0)
            return -1;
        else
            return 1;
    }
    public int checkAnswer2(string a1, string userName)             //验证密保问题2
    {
        string sql = "select answer1 from pwdQuestions where userName = N'" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        int count = dt.Rows.Count;
        if (count == 0)
            return -1;
        else
            return 1;
    }
    public int checkAnswer3(string a1, string userName)             //验证密保问题3
    {
        string sql = "select answer1 from pwdQuestions where userName = N'" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        System.Data.DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
        conn.Close();
        int count = dt.Rows.Count;
        if (count == 0)
            return -1;
        else
            return 1;
    }
    public int registerJudge(string userName, string password)
    {
        if (userName != "" && password != "")
        {
            if (userName.Contains(" ") || password.Contains(" "))
                return -1;
            else
            {
                if (userName.Length > 10 || password.Length < 6 || password.Length > 24)
                    return -1;
                else
                    return 1;
            }
        }
        else
            return -1;
    }
    public int nullJudge(string str)                //空值判断
    {
        if (str == "")
            return -1;
        else
            return 1;
    }
    public int changeJudge(string password)
    {
        if (password != "")
        {
            if (password.Contains(" "))
                return -1;
            else
                return 1;
        }
        else
            return -1;
    }
    public void deleteUser(string userName)
    {
        string sql = "delete from Users where userName = '" + userName + "'";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}