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
    public partial class FrmChangePassword : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public FrmChangePassword()
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
                if (txtOldPwd.Text.Length == 0)
                {
                    MessageBox.Show("Enter Old Password.");
                    txtOldPwd.Focus();
                    return;
                }
                if (txtNewPwd.Text.Length == 0)
                {
                    MessageBox.Show("Enter new Password.");
                    txtNewPwd.Focus();
                    return;
                }


                UserMst lqry = dbx.UserMsts.Where(u => u.UserId == AppInit.UserInfo.UserId && u.Password == txtOldPwd.Text).FirstOrDefault();
                if (lqry == null)
                {
                    MessageBox.Show("Old password dose not match.");
                    txtOldPwd.Focus();
                    return;
                }
                lqry.Password = txtNewPwd.Text;
                dbx.SaveChanges();
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void BtnlQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
