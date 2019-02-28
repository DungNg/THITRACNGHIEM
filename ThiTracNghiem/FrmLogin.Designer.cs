namespace ThiTracNghiem
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.cbxCoso = new System.Windows.Forms.ComboBox();
            this.tN_CSDLPTDataSet = new ThiTracNghiem.TN_CSDLPTDataSet();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new ThiTracNghiem.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDangnhap);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMatkhau);
            this.panel2.Controls.Add(this.txtTendangnhap);
            this.panel2.Controls.Add(this.cbxCoso);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 153);
            this.panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(218, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(137, 122);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangnhap.TabIndex = 7;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(199, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Hiện mật khẩu";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cơ sở";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(96, 71);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(197, 21);
            this.txtMatkhau.TabIndex = 2;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(96, 43);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(197, 21);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // cbxCoso
            // 
            this.cbxCoso.DataSource = this.bdsPM;
            this.cbxCoso.DisplayMember = "TENDAYDU";
            this.cbxCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoso.FormattingEnabled = true;
            this.cbxCoso.Location = new System.Drawing.Point(96, 15);
            this.cbxCoso.Name = "cbxCoso";
            this.cbxCoso.Size = new System.Drawing.Size(197, 21);
            this.cbxCoso.TabIndex = 0;
            this.cbxCoso.ValueMember = "TENSERVER";
            this.cbxCoso.SelectedIndexChanged += new System.EventHandler(this.cbxChinhanh_SelectedIndexChanged);
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.tN_CSDLPTDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(331, 182);
            this.Controls.Add(this.panel2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.ComboBox cbxCoso;
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource bdsPM;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}