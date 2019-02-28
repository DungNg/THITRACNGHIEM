namespace ThiTracNghiem
{
    partial class FrmChuanbithi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.cbxMamh = new System.Windows.Forms.ComboBox();
            this.cbxLanthi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThi = new System.Windows.Forms.Button();
            this.cbxMalop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkNgaythi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn học: ";
            // 
            // txtMasv
            // 
            this.txtMasv.Enabled = false;
            this.txtMasv.Location = new System.Drawing.Point(91, 11);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(162, 21);
            this.txtMasv.TabIndex = 2;
            // 
            // cbxMamh
            // 
            this.cbxMamh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMamh.Enabled = false;
            this.cbxMamh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMamh.FormattingEnabled = true;
            this.cbxMamh.Location = new System.Drawing.Point(91, 92);
            this.cbxMamh.Name = "cbxMamh";
            this.cbxMamh.Size = new System.Drawing.Size(162, 21);
            this.cbxMamh.TabIndex = 3;
            this.cbxMamh.SelectedIndexChanged += new System.EventHandler(this.cbxMamh_SelectedIndexChanged);
            // 
            // cbxLanthi
            // 
            this.cbxLanthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanthi.Enabled = false;
            this.cbxLanthi.FormattingEnabled = true;
            this.cbxLanthi.Location = new System.Drawing.Point(91, 119);
            this.cbxLanthi.Name = "cbxLanthi";
            this.cbxLanthi.Size = new System.Drawing.Size(54, 21);
            this.cbxLanthi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lần thi: ";
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(178, 146);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(75, 23);
            this.btnThi.TabIndex = 6;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // cbxMalop
            // 
            this.cbxMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMalop.Enabled = false;
            this.cbxMalop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMalop.FormattingEnabled = true;
            this.cbxMalop.Location = new System.Drawing.Point(91, 38);
            this.cbxMalop.Name = "cbxMalop";
            this.cbxMalop.Size = new System.Drawing.Size(162, 21);
            this.cbxMalop.TabIndex = 7;
            this.cbxMalop.SelectedIndexChanged += new System.EventHandler(this.cbxMalop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã lớp: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpkNgaythi
            // 
            this.dtpkNgaythi.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaythi.Enabled = false;
            this.dtpkNgaythi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaythi.Location = new System.Drawing.Point(91, 65);
            this.dtpkNgaythi.Name = "dtpkNgaythi";
            this.dtpkNgaythi.Size = new System.Drawing.Size(162, 21);
            this.dtpkNgaythi.TabIndex = 9;
            this.dtpkNgaythi.ValueChanged += new System.EventHandler(this.dtpkNgaythi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày thi: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "In bài thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmChuanbithi
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpkNgaythi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMalop);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxLanthi);
            this.Controls.Add(this.cbxMamh);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmChuanbithi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuẩn bị thi";
            this.Load += new System.EventHandler(this.FrmChuanbithi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThi;
        public System.Windows.Forms.TextBox txtMasv;
        public System.Windows.Forms.ComboBox cbxMamh;
        public System.Windows.Forms.ComboBox cbxLanthi;
        private System.Windows.Forms.ComboBox cbxMalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkNgaythi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}