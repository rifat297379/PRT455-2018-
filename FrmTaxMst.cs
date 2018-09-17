using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv
{
    public partial class FrmTaxMst : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        
        public int mPkValue = 0;
        public FrmTaxMst()
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
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmCompanyMst_Load(object sender, EventArgs e)
        {
            doSetControls();
        
        }
        void doSetControls()
        {            
            
        }
        void LoadData()
        {
            if (mPkValue > 0)
            {
                var lqry = dbx.TaxMsts.Where(u=> u.TaxId== mPkValue).FirstOrDefault();
                if (lqry != null)
                {
                    txtTaxName.Text = lqry.TaxName;
                    txtIGST.Text = lqry.IGST.ToString();
                    txtCGST.Text = lqry.CGST.ToString();
                    txtSGST.Text = lqry.SGST.ToString();
                }
            }
        }

        private void FrmCompanyMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F8)
            {
                btnList_Click(sender, e);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTaxName.Text.Length == 0)
            {
                MessageBox.Show("Kindly enter tax name.");
                txtTaxName.Focus();
                return;
            }
           
            if (mPkValue == 0)
            {
                TaxMst objtxm= new TaxMst();

                objtxm.TaxName = txtTaxName.Text;
                //objtxm.IGST = Convert.ToDecimal(Convert.ToDouble(txtIGST.Text));
                //objtxm.CGST = Convert.ToDecimal(Convert.ToDouble(txtCGST.Text));
                //objtxm.SGST = Convert.ToDecimal(Convert.ToDouble(txtSGST.Text));
                objtxm.IGST = AppFun.ToDecimal(txtIGST.Text);
                objtxm.CGST = AppFun.ToDecimal(txtCGST.Text);
                objtxm.SGST = AppFun.ToDecimal(txtSGST.Text);
                
                dbx.TaxMsts.Add(objtxm);
                dbx.SaveChanges();

                MessageBox.Show("Tax detail saved..");
            }
            else
            {
                var objtxm = dbx.TaxMsts.Where(u => u.TaxId == mPkValue).First();
                if (objtxm != null)
                {
                    objtxm.TaxName = txtTaxName.Text;
                    objtxm.IGST = AppFun.ToDecimal(txtIGST.Text);
                    objtxm.CGST = AppFun.ToDecimal(txtCGST.Text);
                    objtxm.SGST = AppFun.ToDecimal(txtSGST.Text);
                    
                    dbx.SaveChanges();
                    MessageBox.Show("Item detail updated..");
                }

            }
            ClearControls();
                
        }
        void ClearControls()
        {
            txtTaxName.Text = "";           
            txtIGST.Text = "0";
            txtCGST.Text = "0";
            txtSGST.Text = "0";            
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            FrmTaxList objtxmlist = new FrmTaxList();
            objtxmlist.ShowDialog();
        }

       

        private void FrmCustomerMst_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

       
    }
}