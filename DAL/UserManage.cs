using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserManage
    {
        public bool JudgeUser(Entity.UserInfo user)
        {
            //DataTable dt
            //string sql = "select * from T_User where UserId = user.UserName and Psw= user.Pwd";
            //1.创建数据库通道
            SqlConnection conn = new SqlConnection("server=.;database=ComputerCharge_sys;uid=sa;pwd=1");
            //2.写sql语句，并告知sqlcommand链接通道
            SqlCommand cmd = new SqlCommand("select * from T_User where UserId=@name And Psw=@pwd",conn);
            cmd.Parameters.AddWithValue("@name",user.UserName);
            cmd.Parameters.AddWithValue("@pwd",user.Pwd);
            //3.打开数据库通道
            conn.Open();
            //4.执行sql语句
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
                
            }



        }
    }
}
