namespace Inv
{
    partial class FrmReportGrid
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
            this.PnlTool = new DevExpress.XtraEditors.PanelControl();
            this.btnSaveFormat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportXls = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportPdf = new DevExpress.XtraEditors.SimpleButton();
            this.xList = new DevExpress.XtraGrid.GridControl();
            this.xListDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.PnlTool)).BeginInit();
            this.PnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xListDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTool
            // 
            this.PnlTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTool.Controls.Add(this.btnSaveFormat);
            this.PnlTool.Controls.Add(this.BtnPrint);
            this.PnlTool.Controls.Add(this.btnExportXls);
            this.PnlTool.Controls.Add(this.btnExportPdf);
            this.PnlTool.Location = new System.Drawing.Point(0, 0);
            this.PnlTool.LookAndFeel.SkinName = "Office 2010 Silver";
            this.PnlTool.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PnlTool.Name = "PnlTool";
            this.PnlTool.Size = new System.Drawing.Size(893, 39);
            this.PnlTool.TabIndex = 18;
            // 
            // btnSaveFormat
            // 
            this.btnSaveFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFormat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSaveFormat.Image = global::Inv.Properties.Resources.if_file_Doc_download_1379785;
            this.btnSaveFormat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSaveFormat.Location = new System.Drawing.Point(750, 5);
            this.btnSaveFormat.Name = "btnSaveFormat";
            this.btnSaveFormat.Size = new System.Drawing.Size(30, 30);
            this.btnSaveFormat.TabIndex = 3;
            this.btnSaveFormat.ToolTip = "Save this format";
            this.btnSaveFormat.Click += new System.EventHandler(this.btnSaveFormat_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnPrint.Image = global::Inv.Properties.Resources.if_BT_print_905645;
            this.BtnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnPrint.Location = new System.Drawing.Point(786, 5);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(30, 30);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.ToolTip = "Preview";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnExportXls
            // 
            this.btnExportXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportXls.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExportXls.Image = global::Inv.Properties.Resources.if_file_10_1377262;
            this.btnExportXls.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportXls.Location = new System.Drawing.Point(822, 5);
            this.btnExportXls.Name = "btnExportXls";
            this.btnExportXls.Size = new System.Drawing.Size(30, 30);
            this.btnExportXls.TabIndex = 1;
            this.btnExportXls.ToolTip = "Export To XLS";
            this.btnExportXls.Click += new System.EventHandler(this.btnExportXls_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPdf.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExportPdf.Image = global::Inv.Properties.Resources.if_file_expand_Pdf_1379078;
            this.btnExportPdf.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnExportPdf.Location = new System.Drawing.Point(858, 5);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(30, 30);
            this.btnExportPdf.TabIndex = 0;
            this.btnExportPdf.ToolTip = "Export To PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // xList
            // 
            this.xList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xList.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.xList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xList.Location = new System.Drawing.Point(0, 40);
            this.xList.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.xList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xList.MainView = this.xListDetail;
            this.xList.Name = "xList";
            this.xList.Size = new System.Drawing.Size(893, 476);
            this.xList.TabIndex = 19;
            this.xList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xListDetail});
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
            this.xListDetail.OptionsView.ColumnAutoWidth = false;
            this.xListDetail.OptionsView.ShowAutoFilterRow = true;
            this.xListDetail.OptionsView.ShowFooter = true;
            // 
            // FrmReportGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 515);
            this.Controls.Add(this.xList);
            this.Controls.Add(this.PnlTool);
            this.KeyPreview = true;
            this.Name = "FrmReportGrid";
            this.ShowInTaskbar = false;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportGrid_Load);
            this.Shown += new System.EventHandler(this.FrmReportGrid_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReportGrid_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmReportGrid_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PnlTool)).EndInit();
            this.PnlTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xListDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PnlTool;
        public DevExpress.XtraGrid.GridControl xList;
        private DevExpress.XtraGrid.Views.Grid.GridView xListDetail;
        private DevExpress.XtraEditors.SimpleButton btnExportXls;
        private DevExpress.XtraEditors.SimpleButton btnExportPdf;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSaveFormat;

    }
}