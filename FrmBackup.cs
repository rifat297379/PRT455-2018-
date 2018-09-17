using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
namespace Inv
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }
        public bool isPormteMode = false;
        private void btnCancle_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtpath.Text.Length == 0)
            {
                MessageBox.Show("Please choose a back up path.");
                txtpath.Focus();
                return;
            }
            GenerateFullBackup();
            MessageBox.Show("Backup Generated file location.");
        }
        public static void GenerateFullBackup()
        {
            if (AppInit.AppInfo.BackupPath.Length == 0) return;
            DbFun.CloseConn();
            string ltimepunch = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".ikbkp";
            System.IO.Compression.ZipFile.CreateFromDirectory(Application.StartupPath, AppInit.AppInfo.BackupPath + @"\" + ltimepunch);
            DbFun.OpenConn();

        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = op.SelectedPath;
                AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Enum_BackupPath.ToString(), txtpath.Text);
                AppInit.SoftwareSettings.IntiSetting();
            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            if (isPormteMode)
            {
                pnlAskPromte.Visible = true;
                pnlPathOption.Visible = false;
                lblPromptMsg.Text = "Want to generate backup now ? \nAt the location " + AppInit.AppInfo.BackupPath + "";
            }
            else
            {
                pnlAskPromte.Visible = false;
                pnlPathOption.Visible = true;
                txtpath.Text = AppInit.AppInfo.BackupPath;
                chkAskMe.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Enum_AskBackupWhenCloseSoftware.ToString());
            }
            
        }

        private void chkAskMe_CheckedChanged(object sender, EventArgs e)
        {
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Enum_AskBackupWhenCloseSoftware.ToString(), chkAskMe.Checked ? "1" : "0");
            AppInit.SoftwareSettings.IntiSetting();
        }

        private void btnTakeBackup_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            lblPromptMsg.Text = "Bakup Generating please wait....";
            Application.DoEvents();
            GenerateFullBackup();
            Application.DoEvents();
            DialogResult = DialogResult.OK;
        }

        private void btnCancelBackup_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
