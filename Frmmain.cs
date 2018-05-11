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
    public partial class Frmmain : Form
    {
        String str = "";
        public Frmmain()
        {
            InitializeComponent();
        }
        public Frmmain(String _str)
        {
            str = _str;
            InitializeComponent();
        }

        private void lbuser_Click(object sender, EventArgs e)
        {
            //Frmmain f2 = new Frmmain(str);

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {
            lbuser.Text = str;
            //treeView1.Nodes.Add(new TreeNode("tree1"));
            //TreeNode fnode = treeView1.Nodes[0];
            //fnode.Nodes.Add("tree1_1");
            //fnode.Nodes.Add("tree1_2"); 
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Text.ToString() == "张三")
                {
                    lbname.Text = "张三";
                    lbclass.Text = "一班";
                    lbwork.Text = "班长";
                    lbnum.Text = "2015110";
                    lbage.Text = "21";
                    lbaddress.Text = "内蒙古呼和浩特";
                    pictureBox.Image = Image.FromFile(@"D:\C#\test2\test2\picture\e.jpg");
                }
                if (treeView1.SelectedNode.Text.ToString() == "李四")
                {
                    lbname.Text = "李四";
                    lbclass.Text = "一班";
                    lbwork.Text = "学委";
                    lbnum.Text = "2015111";
                    lbage.Text = "21";
                    lbaddress.Text = "内蒙古赤峰";
                    pictureBox.Image = Image.FromFile(@"D:\C#\test2\test2\picture\f.jpg");
                }
                if (treeView1.SelectedNode.Text.ToString() == "王五")
                {
                    lbname.Text = "王五";
                    lbclass.Text = "二班";
                    lbwork.Text = "班长";
                    lbnum.Text = "2015112";
                    lbage.Text = "22";
                    lbaddress.Text = "内蒙古包头";
                    pictureBox.Image = Image.FromFile(@"D:\C#\test2\test2\picture\g.jpg");
                }
                if (treeView1.SelectedNode.Text.ToString() == "赵七")
                {
                    lbname.Text = "赵七";
                    lbclass.Text = "二班";
                    lbwork.Text = "学委";
                    lbnum.Text = "2015113";
                    lbage.Text = "22";
                    lbaddress.Text = "内蒙古呼和浩特";
                    pictureBox.Image = Image.FromFile(@"D:\C#\test2\test2\picture\h.jpg");
                }
                //TreeNode a = e.Node;
                //treeView1.ShowNodeToolTips
                //String nodename = a.Name;
                //switch (nodename)
                //{
                //    case 'tree1_1':
                //}
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(this, "是否退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       




    }

      

       
       

      

     
    }

