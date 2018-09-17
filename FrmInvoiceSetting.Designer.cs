namespace Inv
{
    partial class FrmInvoiceSetting
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
            this.txtChallanFormat = new BControls.bTextBox_text();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPrintChallanEnable = new System.Windows.Forms.CheckBox();
            this.chlOtherAddField = new System.Windows.Forms.CheckBox();
            this.gvBook = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShippingDetails = new System.Windows.Forms.CheckBox();
            this.cmbCopy = new BControls.bComboBox_dx();
            this.label2 = new System.Windows.Forms.Label();
            this.chkItemHelp = new System.Windows.Forms.CheckBox();
            this.lblTotalLevelTax = new System.Windows.Forms.Label();
            this.cmbTotalLevelTax = new DevExpress.XtraEditors.LookUpEdit();
            this.chkInvoiceTaxOnTotalLevel = new System.Windows.Forms.CheckBox();
            this.txtInvoiceFormat = new BControls.bTextBox_text();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.chk_bf_discount = new System.Windows.Forms.CheckBox();
            this.chk_bf_additional = new System.Windows.Forms.CheckBox();
            this.chk_bf_freight = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChallanFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTotalLevelTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chk_bf_discount);
            this.panel1.Controls.Add(this.chk_bf_additional);
            this.panel1.Controls.Add(this.chk_bf_freight);
            this.panel1.Controls.Add(this.txtChallanFormat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkPrintChallanEnable);
            this.panel1.Controls.Add(this.chlOtherAddField);
            this.panel1.Controls.Add(this.gvBook);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkShippingDetails);
            this.panel1.Controls.Add(this.cmbCopy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkItemHelp);
            this.panel1.Controls.Add(this.lblTotalLevelTax);
            this.panel1.Controls.Add(this.cmbTotalLevelTax);
            this.panel1.Controls.Add(this.chkInvoiceTaxOnTotalLevel);
            this.panel1.Controls.Add(this.txtInvoiceFormat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 330);
            this.panel1.TabIndex = 0;
            // 
            // txtChallanFormat
            // 
            this.txtChallanFormat.Location = new System.Drawing.Point(112, 152);
            this.txtChallanFormat.Name = "txtChallanFormat";
            this.txtChallanFormat.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanFormat.Properties.Appearance.Options.UseFont = true;
            this.txtChallanFormat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtChallanFormat.Size = new System.Drawing.Size(272, 22);
            this.txtChallanFormat.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Challan Format";
            // 
            // chkPrintChallanEnable
            // 
            this.chkPrintChallanEnable.AutoSize = true;
            this.chkPrintChallanEnable.Location = new System.Drawing.Point(24, 107);
            this.chkPrintChallanEnable.Name = "chkPrintChallanEnable";
            this.chkPrintChallanEnable.Size = new System.Drawing.Size(121, 17);
            this.chkPrintChallanEnable.TabIndex = 13;
            this.chkPrintChallanEnable.Text = "Print Challan Enable";
            this.chkPrintChallanEnable.UseVisualStyleBackColor = true;
            // 
            // chlOtherAddField
            // 
            this.chlOtherAddField.AutoSize = true;
            this.chlOtherAddField.Location = new System.Drawing.Point(24, 84);
            this.chlOtherAddField.Name = "chlOtherAddField";
            this.chlOtherAddField.Size = new System.Drawing.Size(137, 17);
            this.chlOtherAddField.TabIndex = 12;
            this.chlOtherAddField.Text = "Enable Other Add fields";
            this.chlOtherAddField.UseVisualStyleBackColor = true;
            // 
            // gvBook
            // 
            this.gvBook.AllowUserToAddRows = false;
            this.gvBook.AllowUserToDeleteRows = false;
            this.gvBook.AllowUserToResizeRows = false;
            this.gvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookName,
            this.BookTitle,
            this.InvNo,
            this.Prefix,
            this.IsActive,
            this.IsDefault});
            this.gvBook.Location = new System.Drawing.Point(484, 16);
            this.gvBook.Name = "gvBook";
            this.gvBook.RowHeadersVisible = false;
            this.gvBook.Size = new System.Drawing.Size(362, 217);
            this.gvBook.TabIndex = 11;
            // 
            // BookId
            // 
            this.BookId.HeaderText = "BookId";
            this.BookId.Name = "BookId";
            this.BookId.Visible = false;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookTitle
            // 
            this.BookTitle.HeaderText = "BookTitle";
            this.BookTitle.Name = "BookTitle";
            // 
            // InvNo
            // 
            this.InvNo.HeaderText = "InvNo";
            this.InvNo.Name = "InvNo";
            // 
            // Prefix
            // 
            this.Prefix.HeaderText = "Prefix";
            this.Prefix.Name = "Prefix";
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.Width = 50;
            // 
            // IsDefault
            // 
            this.IsDefault.HeaderText = "IsDefault";
            this.IsDefault.Name = "IsDefault";
            this.IsDefault.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(408, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Default Book";
            // 
            // chkShippingDetails
            // 
            this.chkShippingDetails.AutoSize = true;
            this.chkShippingDetails.Location = new System.Drawing.Point(24, 61);
            this.chkShippingDetails.Name = "chkShippingDetails";
            this.chkShippingDetails.Size = new System.Drawing.Size(138, 17);
            this.chkShippingDetails.TabIndex = 9;
            this.chkShippingDetails.Text = "Enable Shipping Details";
            this.chkShippingDetails.UseVisualStyleBackColor = true;
            // 
            // cmbCopy
            // 
            this.cmbCopy.Location = new System.Drawing.Point(112, 237);
            this.cmbCopy.Name = "cmbCopy";
            this.cmbCopy.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCopy.Properties.Appearance.Options.UseFont = true;
            this.cmbCopy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCopy.Properties.Items.AddRange(new object[] {
            "Original",
            "Duplicate",
            "Triplicate"});
            this.cmbCopy.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbCopy.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbCopy.Size = new System.Drawing.Size(155, 22);
            this.cmbCopy.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Default Copy Tag";
            // 
            // chkItemHelp
            // 
            this.chkItemHelp.AutoSize = true;
            this.chkItemHelp.Location = new System.Drawing.Point(24, 38);
            this.chkItemHelp.Name = "chkItemHelp";
            this.chkItemHelp.Size = new System.Drawing.Size(107, 17);
            this.chkItemHelp.TabIndex = 1;
            this.chkItemHelp.Text = "Enable Item Help";
            this.chkItemHelp.UseVisualStyleBackColor = true;
            // 
            // lblTotalLevelTax
            // 
            this.lblTotalLevelTax.AutoSize = true;
            this.lblTotalLevelTax.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLevelTax.Location = new System.Drawing.Point(21, 212);
            this.lblTotalLevelTax.Name = "lblTotalLevelTax";
            this.lblTotalLevelTax.Size = new System.Drawing.Size(62, 13);
            this.lblTotalLevelTax.TabIndex = 4;
            this.lblTotalLevelTax.Text = "Default Tax";
            // 
            // cmbTotalLevelTax
            // 
            this.cmbTotalLevelTax.Location = new System.Drawing.Point(112, 208);
            this.cmbTotalLevelTax.Name = "cmbTotalLevelTax";
            this.cmbTotalLevelTax.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalLevelTax.Properties.Appearance.Options.UseFont = true;
            this.cmbTotalLevelTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTotalLevelTax.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbTotalLevelTax.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbTotalLevelTax.Properties.NullText = "";
            this.cmbTotalLevelTax.Properties.PopupSizeable = false;
            this.cmbTotalLevelTax.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTotalLevelTax.Size = new System.Drawing.Size(155, 22);
            this.cmbTotalLevelTax.TabIndex = 5;
            // 
            // chkInvoiceTaxOnTotalLevel
            // 
            this.chkInvoiceTaxOnTotalLevel.AutoSize = true;
            this.chkInvoiceTaxOnTotalLevel.Location = new System.Drawing.Point(24, 15);
            this.chkInvoiceTaxOnTotalLevel.Name = "chkInvoiceTaxOnTotalLevel";
            this.chkInvoiceTaxOnTotalLevel.Size = new System.Drawing.Size(149, 17);
            this.chkInvoiceTaxOnTotalLevel.TabIndex = 0;
            this.chkInvoiceTaxOnTotalLevel.Text = "Invoice Tax on Total level";
            this.chkInvoiceTaxOnTotalLevel.UseVisualStyleBackColor = true;
            // 
            // txtInvoiceFormat
            // 
            this.txtInvoiceFormat.Location = new System.Drawing.Point(112, 180);
            this.txtInvoiceFormat.Name = "txtInvoiceFormat";
            this.txtInvoiceFormat.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceFormat.Properties.Appearance.Options.UseFont = true;
            this.txtInvoiceFormat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtInvoiceFormat.Size = new System.Drawing.Size(272, 22);
            this.txtInvoiceFormat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Print Format";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnQuit);
            this.panelControl1.Location = new System.Drawing.Point(-1, 290);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(865, 39);
            this.panelControl1.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(781, 7);
            this.btnSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // chk_bf_discount
            // 
            this.chk_bf_discount.AutoSize = true;
            this.chk_bf_discount.Location = new System.Drawing.Point(249, 84);
            this.chk_bf_discount.Name = "chk_bf_discount";
            this.chk_bf_discount.Size = new System.Drawing.Size(146, 17);
            this.chk_bf_discount.TabIndex = 18;
            this.chk_bf_discount.Text = "Enable befor tax discount";
            this.chk_bf_discount.UseVisualStyleBackColor = true;
            // 
            // chk_bf_additional
            // 
            this.chk_bf_additional.AutoSize = true;
            this.chk_bf_additional.Location = new System.Drawing.Point(249, 61);
            this.chk_bf_additional.Name = "chk_bf_additional";
            this.chk_bf_additional.Size = new System.Drawing.Size(152, 17);
            this.chk_bf_additional.TabIndex = 17;
            this.chk_bf_additional.Text = "Enable befor tax Additional";
            this.chk_bf_additional.UseVisualStyleBackColor = true;
            // 
            // chk_bf_freight
            // 
            this.chk_bf_freight.AutoSize = true;
            this.chk_bf_freight.Location = new System.Drawing.Point(249, 38);
            this.chk_bf_freight.Name = "chk_bf_freight";
            this.chk_bf_freight.Size = new System.Drawing.Size(135, 17);
            this.chk_bf_freight.TabIndex = 16;
            this.chk_bf_freight.Text = "Enable befor tax freight";
            this.chk_bf_freight.UseVisualStyleBackColor = true;
            // 
            // FrmInvoiceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 341);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmInvoiceSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Setting";
            this.Load += new System.EventHandler(this.FrmInvoiceSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInvoiceSetting_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChallanFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTotalLevelTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BControls.bTextBox_text txtInvoiceFormat;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private System.Windows.Forms.CheckBox chkInvoiceTaxOnTotalLevel;
        private System.Windows.Forms.Label lblTotalLevelTax;
        private DevExpress.XtraEditors.LookUpEdit cmbTotalLevelTax;
        private System.Windows.Forms.CheckBox chkItemHelp;
        private System.Windows.Forms.Label label2;
        private BControls.bComboBox_dx cmbCopy;
        private System.Windows.Forms.CheckBox chkShippingDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefix;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDefault;
        private System.Windows.Forms.CheckBox chlOtherAddField;
        private System.Windows.Forms.CheckBox chkPrintChallanEnable;
        private BControls.bTextBox_text txtChallanFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_bf_discount;
        private System.Windows.Forms.CheckBox chk_bf_additional;
        private System.Windows.Forms.CheckBox chk_bf_freight;
    }
}