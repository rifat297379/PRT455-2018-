namespace Inv
{
    partial class FrmInvoiceList
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintChallan = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCopy = new BControls.bComboBox_dx();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.xListDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xList = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xListDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnPrintChallan);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.cmbCopy);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnList);
            this.panelControl1.Controls.Add(this.btnQuit);
            this.panelControl1.Location = new System.Drawing.Point(0, 632);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 39);
            this.panelControl1.TabIndex = 17;
            // 
            // btnPrintChallan
            // 
            this.btnPrintChallan.Location = new System.Drawing.Point(472, 7);
            this.btnPrintChallan.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnPrintChallan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrintChallan.Name = "btnPrintChallan";
            this.btnPrintChallan.Size = new System.Drawing.Size(106, 23);
            this.btnPrintChallan.TabIndex = 7;
            this.btnPrintChallan.Text = "Print &Challan";
            this.btnPrintChallan.Visible = false;
            this.btnPrintChallan.Click += new System.EventHandler(this.btnPrintChallan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(271, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Copy";
            // 
            // cmbCopy
            // 
            this.cmbCopy.Location = new System.Drawing.Point(309, 8);
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
            this.cmbCopy.Size = new System.Drawing.Size(157, 22);
            this.cmbCopy.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(171, 7);
            this.btnPrint.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(924, 7);
            this.btnSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Edit";
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
            this.btnList.Text = "&Delete";
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
            // xListDetail
            // 
            this.xListDetail.GridControl = this.xList;
            this.xListDetail.Name = "xListDetail";
            this.xListDetail.OptionsBehavior.AutoExpandAllGroups = true;
            this.xListDetail.OptionsBehavior.Editable = false;
            this.xListDetail.OptionsDetail.SmartDetailHeight = true;
            this.xListDetail.OptionsFind.AlwaysVisible = true;
            this.xListDetail.OptionsFind.FindDelay = 500;
            this.xListDetail.OptionsView.ShowAutoFilterRow = true;
            this.xListDetail.OptionsView.ShowFooter = true;
            this.xListDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xListDetail_KeyDown);
            // 
            // xList
            // 
            this.xList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xList.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.xList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xList.Location = new System.Drawing.Point(0, 0);
            this.xList.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.xList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xList.MainView = this.xListDetail;
            this.xList.Name = "xList";
            this.xList.Size = new System.Drawing.Size(1008, 633);
            this.xList.TabIndex = 18;
            this.xList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xListDetail});
            // 
            // FrmInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 671);
            this.Controls.Add(this.xList);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FrmInvoiceList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerList_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            this.Shown += new System.EventHandler(this.FrmCustomerList_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCustomerList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xListDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private BControls.bComboBox_dx cmbCopy;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnPrintChallan;
        private DevExpress.XtraGrid.Views.Grid.GridView xListDetail;
        public DevExpress.XtraGrid.GridControl xList;
    }
}