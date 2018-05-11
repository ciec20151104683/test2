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
    public partial class FrmInfor : Form
    {
        public FrmInfor()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataColumn colName = new DataColumn("colName");
            DataColumn colSName = new DataColumn("colSName");
            DataColumn colClass = new DataColumn("colClass");
            DataColumn colSex = new DataColumn("colSex");
            DataColumn colAge = new DataColumn("colAge");
            DataColumn colAdd = new DataColumn("colAdd");
            DataColumn colDuty= new DataColumn("colDuty");

            dt.Columns.Add(colName);
            dt.Columns.Add(colSName);
            dt.Columns.Add(colClass);
            dt.Columns.Add(colSex);
            dt.Columns.Add(colAge);
            dt.Columns.Add(colAdd);
            dt.Columns.Add(colDuty);

            DataRow dr = dt.NewRow();
            dr["colName"] = txtName.Text;
            dr["colSName"] = txtSName.Text;
            dr["colClass"] = txtClass.Text;
            dr["colSex"] = txtSex.Text;
            dr["colAge"] = txtAge.Text;
            dr["colAdd"] = txtAdd.Text;
            dr["colDuty"] = txtDuty.Text;

            dt.Rows.Add(dr);
            dgvInfo.DataSource = dt;

        }
    }
}
