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
            if (txtusername.Text == "student" && txtpassword.Text == "123456")
            {
                string str = txtusername.Text ;
                Frmstudent f1 = new Frmstudent(str);
                f1.Show();
            }
            else if (txtusername.Text == "test" && txtpassword.Text == "123456")
            {
                string b = txtusername.Text;
                Frmadmincs f2 = new Frmadmincs(b);
                f2.Show();
                
            }
            else if (txtusername.Text == "teacher" && txtpassword.Text == "123456")
            {
                string c = txtusername.Text;
                Frmteacher f3 = new Frmteacher(c);
                f3.Show();

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
