namespace ThiTracNghiem
{
    partial class FrmInBaiThi
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLanthi = new System.Windows.Forms.ComboBox();
            this.cbxMamh = new System.Windows.Forms.ComboBox();
            this.cbxMalop = new System.Windows.Forms.ComboBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxLanthi);
            this.groupBox1.Controls.Add(this.cbxMamh);
            this.groupBox1.Controls.Add(this.cbxMalop);
            this.groupBox1.Controls.Add(this.txtMasv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lần thi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Môn thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sinh viên: ";
            // 
            // cbxLanthi
            // 
            this.cbxLanthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanthi.FormattingEnabled = true;
            this.cbxLanthi.Location = new System.Drawing.Point(92, 102);
            this.cbxLanthi.Name = "cbxLanthi";
            this.cbxLanthi.Size = new System.Drawing.Size(121, 21);
            this.cbxLanthi.TabIndex = 3;
            // 
            // cbxMamh
            // 
            this.cbxMamh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMamh.FormattingEnabled = true;
            this.cbxMamh.Location = new System.Drawing.Point(92, 75);
            this.cbxMamh.Name = "cbxMamh";
            this.cbxMamh.Size = new System.Drawing.Size(121, 21);
            this.cbxMamh.TabIndex = 2;
            this.cbxMamh.SelectedIndexChanged += new System.EventHandler(this.cbxMamh_SelectedIndexChanged);
            // 
            // cbxMalop
            // 
            this.cbxMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMalop.FormattingEnabled = true;
            this.cbxMalop.Location = new System.Drawing.Point(92, 47);
            this.cbxMalop.Name = "cbxMalop";
            this.cbxMalop.Size = new System.Drawing.Size(121, 21);
            this.cbxMalop.TabIndex = 1;
            this.cbxMalop.SelectedIndexChanged += new System.EventHandler(this.cbxMalop_SelectedIndexChanged);
            // 
            // txtMasv
            // 
            this.txtMasv.Enabled = false;
            this.txtMasv.Location = new System.Drawing.Point(92, 20);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(100, 21);
            this.txtMasv.TabIndex = 0;
            this.txtMasv.TextChanged += new System.EventHandler(this.txtMasv_TextChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 165);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(773, 377);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // FrmInBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 542);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInBaiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInBaiThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInBaiThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLanthi;
        private System.Windows.Forms.ComboBox cbxMamh;
        private System.Windows.Forms.ComboBox cbxMalop;
        private System.Windows.Forms.TextBox txtMasv;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}