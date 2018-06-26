namespace test2
{
    partial class Frmadmincs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbuser1 = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.btnlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.lbuser1);
            this.groupBox1.Controls.Add(this.lbuser);
            this.groupBox1.Controls.Add(this.btnlist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(79, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(1492, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统状态";
            // 
            // lbuser1
            // 
            this.lbuser1.AutoSize = true;
            this.lbuser1.Location = new System.Drawing.Point(199, 65);
            this.lbuser1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbuser1.Name = "lbuser1";
            this.lbuser1.Size = new System.Drawing.Size(75, 20);
            this.lbuser1.TabIndex = 3;
            this.lbuser1.Text = "label2";
           
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(387, 63);
            this.lbuser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(0, 26);
            this.lbuser.TabIndex = 2;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(1194, 42);
            this.btnlist.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(220, 68);
            this.btnlist.TabIndex = 1;
            this.btnlist.Text = "加载列表";
            this.btnlist.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前登录用户：";
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.MediumAquamarine;
            this.student.Location = new System.Drawing.Point(217, 258);
            this.student.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(150, 59);
            this.student.TabIndex = 2;
            this.student.Text = "添加学生";
            this.student.UseVisualStyleBackColor = false;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.delete.Location = new System.Drawing.Point(420, 258);
            this.delete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 59);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除学生";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Location = new System.Drawing.Point(625, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "修改学生信息";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.MediumAquamarine;
            this.select.Location = new System.Drawing.Point(217, 378);
            this.select.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(150, 59);
            this.select.TabIndex = 5;
            this.select.Text = "添加课程";
            this.select.UseVisualStyleBackColor = false;
            // 
            // Frmadmincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.select);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.student);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frmadmincs";
            this.Text = "Frmadmincs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbuser1;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button select;
    }
}