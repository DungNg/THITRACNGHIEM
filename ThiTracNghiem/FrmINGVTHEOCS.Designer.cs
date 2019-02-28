namespace ThiTracNghiem
{
    partial class FrmINGVTHEOCS
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
            this.tN_CSDLPTDataSet = new ThiTracNghiem.TN_CSDLPTDataSet();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new ThiTracNghiem.TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.TN_CSDLPTDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCoso = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tN_CSDLPTDataSet
            // 
            this.tN_CSDLPTDataSet.DataSetName = "TN_CSDLPTDataSet";
            this.tN_CSDLPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.tN_CSDLPTDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.TN_CSDLPTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxCoso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 60);
            this.panel1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở : ";
            // 
            // cbxCoso
            // 
            this.cbxCoso.DisplayMember = "TENDAYDU";
            this.cbxCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCoso.FormattingEnabled = true;
            this.cbxCoso.Location = new System.Drawing.Point(62, 8);
            this.cbxCoso.Name = "cbxCoso";
            this.cbxCoso.Size = new System.Drawing.Size(169, 21);
            this.cbxCoso.TabIndex = 0;
            this.cbxCoso.ValueMember = "TENSERVER";
            this.cbxCoso.SelectedIndexChanged += new System.EventHandler(this.cbxCoso_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(769, 431);
            this.crystalReportViewer1.TabIndex = 23;
            // 
            // FrmINGVTHEOCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 491);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmINGVTHEOCS";
            this.Text = "FrmINGVTHEOCS";
            this.Load += new System.EventHandler(this.FrmINGVTHEOCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tN_CSDLPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TN_CSDLPTDataSet tN_CSDLPTDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TN_CSDLPTDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private TN_CSDLPTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCoso;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}