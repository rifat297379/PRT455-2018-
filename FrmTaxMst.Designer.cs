namespace Inv
{
    partial class FrmTaxMst
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSGST = new BControls.bTextBox_numeric();
            this.txtCGST = new BControls.bTextBox_numeric();
            this.txtIGST = new BControls.bTextBox_numeric();
            this.txtTaxName = new BControls.bTextBox_text();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCGST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSGST);
            this.panel1.Controls.Add(this.txtCGST);
            this.panel1.Controls.Add(this.txtIGST);
            this.panel1.Controls.Add(this.txtTaxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 145);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(283, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 6;
            this.label11.Text = "SGST";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(191, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "CGST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(102, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "IGST";
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(326, 45);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Properties.Appearance.Options.UseFont = true;
            this.txtSGST.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSGST.Properties.Mask.EditMask = "n";
            this.txtSGST.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSGST.Properties.NullText = "0";
            this.txtSGST.Properties.NullValuePrompt = "0";
            this.txtSGST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSGST.Size = new System.Drawing.Size(43, 22);
            this.txtSGST.TabIndex = 7;
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(234, 45);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Properties.Appearance.Options.UseFont = true;
            this.txtCGST.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCGST.Properties.Mask.EditMask = "n";
            this.txtCGST.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCGST.Properties.NullText = "0";
            this.txtCGST.Properties.NullValuePrompt = "0";
            this.txtCGST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCGST.Size = new System.Drawing.Size(43, 22);
            this.txtCGST.TabIndex = 5;
            // 
            // txtIGST
            // 
            this.txtIGST.Location = new System.Drawing.Point(142, 45);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Properties.Appearance.Options.UseFont = true;
            this.txtIGST.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtIGST.Properties.Mask.EditMask = "n";
            this.txtIGST.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIGST.Properties.NullText = "0";
            this.txtIGST.Properties.NullValuePrompt = "0";
            this.txtIGST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIGST.Size = new System.Drawing.Size(43, 22);
            this.txtIGST.TabIndex = 3;
            // 
            // txtTaxName
            // 
            this.txtTaxName.Location = new System.Drawing.Point(99, 17);
            this.txtTaxName.Name = "txtTaxName";
            this.txtTaxName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxName.Properties.Appearance.Options.UseFont = true;
            this.txtTaxName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTaxName.Size = new System.Drawing.Size(272, 22);
            this.txtTaxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnList);
            this.panelControl1.Controls.Add(this.btnQuit);
            this.panelControl1.Location = new System.Drawing.Point(-1, 105);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(418, 39);
            this.panelControl1.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(334, 7);
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
            // FrmTaxMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 152);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmTaxMst";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxes Entry";
            this.Activated += new System.EventHandler(this.FrmCustomerMst_Activated);
            this.Load += new System.EventHandler(this.FrmCompanyMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompanyMst_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCGST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxName.Properties)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private BControls.bTextBox_text txtTaxName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private BControls.bTextBox_numeric txtSGST;
        private BControls.bTextBox_numeric txtCGST;
        private BControls.bTextBox_numeric txtIGST;

    }
}