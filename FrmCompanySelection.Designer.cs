namespace Inv
{
    partial class FrmCompanySelection
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
            this.btnSelect = new BControls.bButton();
            this.xGridCompany = new DevExpress.XtraGrid.GridControl();
            this.gridCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnCreate = new BControls.bButton();
            ((System.ComponentModel.ISupportInitialize)(this.xGridCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnSelect.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.Appearance.Options.UseBackColor = true;
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.Appearance.Options.UseForeColor = true;
            this.btnSelect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSelect.Location = new System.Drawing.Point(361, 225);
            this.btnSelect.LookAndFeel.SkinMaskColor = System.Drawing.Color.Aqua;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 25);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // xGridCompany
            // 
            this.xGridCompany.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.xGridCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xGridCompany.Location = new System.Drawing.Point(-1, 1);
            this.xGridCompany.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.xGridCompany.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xGridCompany.MainView = this.gridCompany;
            this.xGridCompany.Name = "xGridCompany";
            this.xGridCompany.Size = new System.Drawing.Size(437, 219);
            this.xGridCompany.TabIndex = 6;
            this.xGridCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCompany});
            this.xGridCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xGridCompany_KeyDown);
            // 
            // gridCompany
            // 
            this.gridCompany.GridControl = this.xGridCompany;
            this.gridCompany.Name = "gridCompany";
            this.gridCompany.OptionsBehavior.Editable = false;
            this.gridCompany.OptionsView.ShowAutoFilterRow = true;
            this.gridCompany.OptionsView.ShowGroupPanel = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.BtnCreate.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCreate.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCreate.Appearance.Options.UseBackColor = true;
            this.BtnCreate.Appearance.Options.UseFont = true;
            this.BtnCreate.Appearance.Options.UseForeColor = true;
            this.BtnCreate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnCreate.Location = new System.Drawing.Point(4, 225);
            this.BtnCreate.LookAndFeel.SkinMaskColor = System.Drawing.Color.Aqua;
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(86, 25);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create New";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FrmCompanySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 255);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.xGridCompany);
            this.Name = "FrmCompanySelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Selection";
            this.Load += new System.EventHandler(this.FrmCompanySelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xGridCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BControls.bButton btnSelect;
        public DevExpress.XtraGrid.GridControl xGridCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCompany;
        private BControls.bButton BtnCreate;

    }
}