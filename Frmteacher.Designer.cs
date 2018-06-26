namespace test2
{
    partial class Frmteacher
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
            this.lbuser = new System.Windows.Forms.Label();
            this.btnlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbuser2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.lbuser2);
            this.groupBox1.Controls.Add(this.lbuser);
            this.groupBox1.Controls.Add(this.btnlist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统状态";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(211, 38);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(0, 26);
            this.lbuser.TabIndex = 2;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(651, 25);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(120, 41);
            this.btnlist.TabIndex = 1;
            this.btnlist.Text = "加载列表";
            this.btnlist.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前登录用户：";
            // 
            // lbuser2
            // 
            this.lbuser2.AutoSize = true;
            this.lbuser2.Location = new System.Drawing.Point(181, 47);
            this.lbuser2.Name = "lbuser2";
            this.lbuser2.Size = new System.Drawing.Size(41, 12);
            this.lbuser2.TabIndex = 3;
            this.lbuser2.Text = "label2";
            this.lbuser2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frmteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmteacher";
            this.Text = "Frmteacher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbuser2;
    }
}