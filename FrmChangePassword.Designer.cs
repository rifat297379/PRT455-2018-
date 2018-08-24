namespace Inv
{
    partial class FrmChangePassword
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
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPwd = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnlQuit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnChange.Location = new System.Drawing.Point(184, 83);
            this.btnChange.LookAndFeel.SkinName = "Office 2010 Black";
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(70, 27);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "&Change";
            this.btnChange.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(120, 22);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(134, 20);
            this.txtOldPwd.TabIndex = 2;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(120, 48);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Properties.PasswordChar = '#';
            this.txtNewPwd.Size = new System.Drawing.Size(134, 20);
            this.txtNewPwd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 122);
            this.panel1.TabIndex = 0;
            // 
            // BtnlQuit
            // 
            this.BtnlQuit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnlQuit.Location = new System.Drawing.Point(26, 83);
            this.BtnlQuit.LookAndFeel.SkinName = "Office 2010 Black";
            this.BtnlQuit.Name = "BtnlQuit";
            this.BtnlQuit.Size = new System.Drawing.Size(70, 27);
            this.BtnlQuit.TabIndex = 6;
            this.BtnlQuit.Text = "&Quit";
            this.BtnlQuit.Click += new System.EventHandler(this.BtnlQuit_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 124);
            this.Controls.Add(this.BtnlQuit);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnChange;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtOldPwd;
        private DevExpress.XtraEditors.TextEdit txtNewPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BtnlQuit;
    }
}