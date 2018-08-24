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
    public partial class FrmCustomerMst : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public int mPkValue = 0;
        public FrmCustomerMst()
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
            HelperClass.bCombBox_StateCode(cmbState);


        }
        void LoadData()
        {
            if (mPkValue > 0)
            {
                var lqry = dbx.CustomerMsts.Where(u=> u.CustomerId == mPkValue).FirstOrDefault();
                if (lqry != null)
                {
                    txtCustomerName.Text = lqry.CustomerName;
                    txtAddress.Text = lqry.Address;
                    cmbState.Text = lqry.State.ToString();
                    txtStatecode.Text = lqry.StateCode;
                    txtEmailid.Text = lqry.EmailId;
                    txtContactNo.Text = lqry.ContactNo;
                    txtGSTinNo.Text = lqry.TaxNo;
                    txtPanNo.Text = lqry.PANNo;
                    mPkValue = lqry.CustomerId;
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
            if (txtCustomerName.Text.Length == 0)
            {
                MessageBox.Show("Kindly enter customer name.");
                txtCustomerName.Focus();
                return;
            }
            if (cmbState.Text.Length == 0)
            {
                MessageBox.Show("Kindly select state.");
                cmbState.Focus();
                return;
            }
            if (mPkValue == 0)
            {
                CustomerMst objcust = new CustomerMst();

                objcust.CustomerName = txtCustomerName.Text;
                objcust.Address = txtAddress.Text;
                objcust.State = cmbState.Text;
                objcust.StateCode = txtStatecode.Text;
                objcust.EmailId = txtEmailid.Text;
                objcust.ContactNo = txtContactNo.Text;
                objcust.TaxNo = txtGSTinNo.Text;
                objcust.PANNo = txtPanNo.Text;


                dbx.CustomerMsts.Add(objcust);
                dbx.SaveChanges();

                MessageBox.Show("Customer detail saved..");
            }
            else
            {
                var objcmp = dbx.CustomerMsts.Where(u => u.CustomerId == mPkValue).First();
                if (objcmp != null)
                {
                    objcmp.CustomerName = txtCustomerName.Text;
                    objcmp.Address = txtAddress.Text;
                    objcmp.State = cmbState.Text;
                    objcmp.StateCode = txtStatecode.Text;
                    objcmp.EmailId = txtEmailid.Text;
                    objcmp.ContactNo = txtContactNo.Text;
                    objcmp.TaxNo = txtGSTinNo.Text;
                    objcmp.PANNo = txtPanNo.Text;

                    dbx.SaveChanges();

                    MessageBox.Show("Customer detail updated..");
                }

            }
            ClearControls();
                
        }
        void ClearControls()
        {
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            cmbState.Text = "";
            txtStatecode.Text = "";
            txtEmailid.Text = "";
            txtContactNo.Text = "";
            txtGSTinNo.Text = "";
            txtPanNo.Text = "";
            
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            FrmCustomerList objclist = new FrmCustomerList();
            objclist.ShowDialog();
        }

        private void cmbState_Leave(object sender, EventArgs e)
        {
            var lqry = dbx.StateMsts.Where(u => u.StateName == cmbState.Text.Trim()).FirstOrDefault();
            txtStatecode.Text = lqry.StateCode.Trim();
        }

        private void FrmCustomerMst_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        
        }

        private void FrmCustomerMst_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

       
    }
}