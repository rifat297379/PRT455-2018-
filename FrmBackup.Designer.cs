namespace Inv
{
    partial class FrmBackup
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
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.txtpath = new BControls.bTextBox_text();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPathOption = new System.Windows.Forms.Panel();
            this.chkAskMe = new System.Windows.Forms.CheckBox();
            this.pnlAskPromte = new System.Windows.Forms.Panel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnTakeBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelBackup = new DevExpress.XtraEditors.SimpleButton();
            this.lblPromptMsg = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpath.Properties)).BeginInit();
            this.pnlPathOption.SuspendLayout();
            this.pnlAskPromte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGenerate);
            this.panelControl1.Controls.Add(this.btnCancle);
            this.panelControl1.Location = new System.Drawing.Point(0, 88);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(407, 39);
            this.panelControl1.TabIndex = 21;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(288, 7);
            this.btnGenerate.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnGenerate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "&Generate Backup";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(9, 7);
            this.btnCancle.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnCancle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "&Cancel";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(99, 23);
            this.txtpath.Name = "txtpath";
            this.txtpath.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpath.Properties.Appearance.Options.UseFont = true;
            this.txtpath.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtpath.Size = new System.Drawing.Size(228, 22);
            this.txtpath.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Backup Path";
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Location = new System.Drawing.Point(333, 23);
            this.btnChoose.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnChoose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(32, 23);
            this.btnChoose.TabIndex = 24;
            this.btnChoose.Text = "...";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // pnlPathOption
            // 
            this.pnlPathOption.Controls.Add(this.chkAskMe);
            this.pnlPathOption.Controls.Add(this.txtpath);
            this.pnlPathOption.Controls.Add(this.panelControl1);
            this.pnlPathOption.Controls.Add(this.btnChoose);
            this.pnlPathOption.Controls.Add(this.label1);
            this.pnlPathOption.Location = new System.Drawing.Point(0, 3);
            this.pnlPathOption.Name = "pnlPathOption";
            this.pnlPathOption.Size = new System.Drawing.Size(405, 127);
            this.pnlPathOption.TabIndex = 25;
            // 
            // chkAskMe
            // 
            this.chkAskMe.AutoSize = true;
            this.chkAskMe.Location = new System.Drawing.Point(99, 58);
            this.chkAskMe.Name = "chkAskMe";
            this.chkAskMe.Size = new System.Drawing.Size(230, 19);
            this.chkAskMe.TabIndex = 25;
            this.chkAskMe.Text = "Ask me always when close a software";
            this.chkAskMe.UseVisualStyleBackColor = true;
            this.chkAskMe.CheckedChanged += new System.EventHandler(this.chkAskMe_CheckedChanged);
            // 
            // pnlAskPromte
            // 
            this.pnlAskPromte.Controls.Add(this.panelControl2);
            this.pnlAskPromte.Controls.Add(this.lblPromptMsg);
            this.pnlAskPromte.Location = new System.Drawing.Point(0, 3);
            this.pnlAskPromte.Name = "pnlAskPromte";
            this.pnlAskPromte.Size = new System.Drawing.Size(405, 127);
            this.pnlAskPromte.TabIndex = 26;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnTakeBackup);
            this.panelControl2.Controls.Add(this.btnCancelBackup);
            this.panelControl2.Location = new System.Drawing.Point(0, 88);
            this.panelControl2.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(407, 39);
            this.panelControl2.TabIndex = 21;
            // 
            // btnTakeBackup
            // 
            this.btnTakeBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeBackup.Location = new System.Drawing.Point(160, 8);
            this.btnTakeBackup.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnTakeBackup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTakeBackup.Name = "btnTakeBackup";
            this.btnTakeBackup.Size = new System.Drawing.Size(76, 23);
            this.btnTakeBackup.TabIndex = 0;
            this.btnTakeBackup.Text = "&Yes";
            this.btnTakeBackup.Click += new System.EventHandler(this.btnTakeBackup_Click);
            // 
            // btnCancelBackup
            // 
            this.btnCancelBackup.Location = new System.Drawing.Point(242, 8);
            this.btnCancelBackup.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnCancelBackup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancelBackup.Name = "btnCancelBackup";
            this.btnCancelBackup.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBackup.TabIndex = 2;
            this.btnCancelBackup.Text = "&No";
            this.btnCancelBackup.Click += new System.EventHandler(this.btnCancelBackup_Click);
            // 
            // lblPromptMsg
            // 
            this.lblPromptMsg.AutoSize = true;
            this.lblPromptMsg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptMsg.ForeColor = System.Drawing.Color.Black;
            this.lblPromptMsg.Location = new System.Drawing.Point(38, 22);
            this.lblPromptMsg.Name = "lblPromptMsg";
            this.lblPromptMsg.Size = new System.Drawing.Size(205, 18);
            this.lblPromptMsg.TabIndex = 22;
            this.lblPromptMsg.Text = "Want to generate backup now ? ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 8);
            this.btnCancel.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 130);
            this.Controls.Add(this.pnlAskPromte);
            this.Controls.Add(this.pnlPathOption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpath.Properties)).EndInit();
            this.pnlPathOption.ResumeLayout(false);
            this.pnlPathOption.PerformLayout();
            this.pnlAskPromte.ResumeLayout(false);
            this.pnlAskPromte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private BControls.bTextBox_text txtpath;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private System.Windows.Forms.Panel pnlPathOption;
        private System.Windows.Forms.CheckBox chkAskMe;
        private System.Windows.Forms.Panel pnlAskPromte;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTakeBackup;
        private DevExpress.XtraEditors.SimpleButton btnCancelBackup;
        private System.Windows.Forms.Label lblPromptMsg;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}