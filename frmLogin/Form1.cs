using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Entity.UserInfo user = new Entity.UserInfo();
            user.UserName = txtUserName.Text.Trim();
            user.Pwd = txtPwd.Text.Trim();
            BLL.UserManage um = new BLL.UserManage();
            bool result = um.JudgeUser(user);
            if (result==true)
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }
    }
}
