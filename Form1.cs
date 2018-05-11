using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2
{
    public partial class FrmLogin : Form
    {
   
       
        public FrmLogin()
        {
            InitializeComponent();
        }
     
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "123456"||txtusername.Text =="test"&&txtpassword.Text =="123456" )
            {
                string str = txtusername.Text ;
                Frmmain f1 = new Frmmain(str);
                f1.Show();
            }
            else
            {
                MessageBox.Show("用户名密码错误！");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(this,"是否退出","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


        
    }
}
