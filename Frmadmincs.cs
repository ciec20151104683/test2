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
    public partial class Frmadmincs : Form
    {
        String str = "";
        public Frmadmincs(String _str)
        {
            str = _str;
            InitializeComponent();
        }

        

        private void student_Click(object sender, EventArgs e)
        {
            FrmInfor f3 = new FrmInfor();
            f3.Show();
            this.Hide();
        }
    }
}
