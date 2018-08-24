namespace Inv
{
    partial class FrmCompanyMst
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbState = new BControls.bComboBox_dx();
            this.label8 = new System.Windows.Forms.Label();
            this.pBox_Logo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPanNo = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNo = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailid = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatecode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtGSTinNo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComapanyName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnImgBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatecode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSTinNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComapanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnImgBrowse);
            this.panel1.Controls.Add(this.cmbState);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pBox_Logo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPanNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmailid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStatecode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtGSTinNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtComapanyName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 465);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbState
            // 
            this.cmbState.Location = new System.Drawing.Point(168, 137);
            this.cmbState.Name = "cmbState";
            this.cmbState.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.Properties.Appearance.Options.UseFont = true;
            this.cmbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbState.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbState.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbState.Size = new System.Drawing.Size(155, 22);
            this.cmbState.TabIndex = 5;
            this.cmbState.Leave += new System.EventHandler(this.cmbState_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Company Logo";
            // 
            // pBox_Logo
            // 
            this.pBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Logo.Location = new System.Drawing.Point(168, 282);
            this.pBox_Logo.Name = "pBox_Logo";
            this.pBox_Logo.Size = new System.Drawing.Size(100, 100);
            this.pBox_Logo.TabIndex = 16;
            this.pBox_Logo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "PAN No";
            // 
            // txtPanNo
            // 
            this.txtPanNo.Location = new System.Drawing.Point(168, 249);
            this.txtPanNo.Name = "txtPanNo";
            this.txtPanNo.Size = new System.Drawing.Size(452, 20);
            this.txtPanNo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact No";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(168, 195);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(452, 20);
            this.txtContactNo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email Id";
            // 
            // txtEmailid
            // 
            this.txtEmailid.Location = new System.Drawing.Point(168, 167);
            this.txtEmailid.Name = "txtEmailid";
            this.txtEmailid.Size = new System.Drawing.Size(452, 20);
            this.txtEmailid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tax Reg No/ GST";
            // 
            // txtStatecode
            // 
            this.txtStatecode.Enabled = false;
            this.txtStatecode.Location = new System.Drawing.Point(329, 138);
            this.txtStatecode.Name = "txtStatecode";
            this.txtStatecode.Size = new System.Drawing.Size(36, 20);
            this.txtStatecode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "State";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(168, 47);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(452, 81);
            this.txtAddress.TabIndex = 3;
            // 
            // txtGSTinNo
            // 
            this.txtGSTinNo.Location = new System.Drawing.Point(168, 221);
            this.txtGSTinNo.Name = "txtGSTinNo";
            this.txtGSTinNo.Size = new System.Drawing.Size(452, 20);
            this.txtGSTinNo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // txtComapanyName
            // 
            this.txtComapanyName.Location = new System.Drawing.Point(168, 18);
            this.txtComapanyName.Name = "txtComapanyName";
            this.txtComapanyName.Size = new System.Drawing.Size(452, 20);
            this.txtComapanyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnList);
            this.panelControl1.Controls.Add(this.btnQuit);
            this.panelControl1.Location = new System.Drawing.Point(-1, 425);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(644, 39);
            this.panelControl1.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 7);
            this.btnSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(90, 7);
            this.btnList.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "&List ( F8 )";
            this.btnList.Visible = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(9, 7);
            this.btnQuit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnQuit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnImgBrowse
            // 
            this.btnImgBrowse.Location = new System.Drawing.Point(274, 359);
            this.btnImgBrowse.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnImgBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnImgBrowse.Name = "btnImgBrowse";
            this.btnImgBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnImgBrowse.TabIndex = 17;
            this.btnImgBrowse.Text = "...";
            this.btnImgBrowse.Click += new System.EventHandler(this.btnImgBrowse_Click);
            // 
            // FrmCompanyMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 471);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmCompanyMst";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyMst";
            this.Load += new System.EventHandler(this.FrmCompanyMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompanyMst_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatecode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSTinNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComapanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.TextEdit txtComapanyName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtGSTinNo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtStatecode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtEmailid;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtContactNo;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtPanNo;
        private System.Windows.Forms.PictureBox pBox_Logo;
        private System.Windows.Forms.Label label8;
        private BControls.bComboBox_dx cmbState;
        private DevExpress.XtraEditors.SimpleButton btnImgBrowse;

    }
}