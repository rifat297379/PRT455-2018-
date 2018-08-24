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
    public partial class FrmReceiptEntry : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        int mPkValue = 0;
        public FrmReceiptEntry()
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
            LoadData();
            GetMaxReceiptNo();


        }
        void GetMaxReceiptNo()
        {
            var lqry1 = dbx.ReceiptMsts.OrderByDescending(d => d.ReceiptId).Take(1).FirstOrDefault();
            if (lqry1 == null)
            {
                txtReceiptNo.Text = "1";
            }
            else
                txtReceiptNo.Text = (lqry1.ReceiptId + 1).ToString();
        }
        void doSetControls()
        {
            HelperClass.SearchLkp_Customers(LkpCustomerName);
            HelperClass.SearchLkp_CashBank(LkpCashBankAcc);
        }

        void LoadData()
        {
            //var lqry = dbx.CompanyMsts.FirstOrDefault();
            //if (lqry != null)
            //{
            //    txtComapanyName.Text = lqry.CompanyName;
            //    txtAddress.Text = lqry.Address;
            //    cmbState.Text = lqry.State.ToString();
            //    txtStatecode.Text = lqry.StateCode;
            //    txtEmailid.Text = lqry.EmailId;
            //    txtContactNo.Text = lqry.ContactNo;
            //    txtGSTinNo.Text = lqry.TaxNo;
            //    txtPanNo.Text = lqry.PANNo;
            //    mPkValue = lqry.CompId;
            //}
        }

        private void FrmCompanyMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
            //if (txtComapanyName.Text.Length == 0)
            //{
            //    MessageBox.Show("Kindly enter company name.");
            //    txtComapanyName.Focus();
            //    return;
            //}
            //if (cmbState.Text.Length == 0)
            //{
            //    MessageBox.Show("Kindly select state.");
            //    cmbState.Focus();
            //    return;
            //}
            //if (mPkValue == 0)
            //{
            //    CompanyMst objcmp = new CompanyMst();

            //    objcmp.CompanyName = txtComapanyName.Text;
            //    objcmp.Address = txtAddress.Text;
            //    objcmp.State = cmbState.Text;
            //    objcmp.StateCode = txtStatecode.Text;
            //    objcmp.EmailId = txtEmailid.Text;
            //    objcmp.ContactNo = txtContactNo.Text;
            //    objcmp.TaxNo = txtGSTinNo.Text;
            //    objcmp.PANNo = txtPanNo.Text;


            //    dbx.CompanyMsts.Add(objcmp);
            //    dbx.SaveChanges();

            //    MessageBox.Show("Company detail saved..");
            //}
            //else
            //{
            //    var objcmp = dbx.CompanyMsts.Where(u => u.CompId == mPkValue).First();
            //    if (objcmp != null)
            //    {
            //        objcmp.CompanyName = txtComapanyName.Text;
            //        objcmp.Address = txtAddress.Text;
            //        objcmp.State = cmbState.Text;
            //        objcmp.StateCode = txtStatecode.Text;
            //        objcmp.EmailId = txtEmailid.Text;
            //        objcmp.ContactNo = txtContactNo.Text;
            //        objcmp.TaxNo = txtGSTinNo.Text;
            //        objcmp.PANNo = txtPanNo.Text;

            //        dbx.SaveChanges();

            //        MessageBox.Show("Company detail updated..");
            //    }

            //}

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FrmReceiptList objilist = new FrmReceiptList();
            objilist.ShowDialog();
        }

        private void LkpCustomerName_Leave(object sender, EventArgs e)
        {
            try
            {
                int lcustid = Convert.ToInt32(LkpCustomerName.EditValue);

                var lqry = (from c in dbx.InvoiceMsts
                            where c.CustomerId == lcustid
                            select c).ToList();
                if (lqry != null)
                {
                    dgvBills.Rows.Clear();
                    foreach (var litem in lqry)
                    {
                        int rowId = dgvBills.Rows.Add();

                        dgvBills.Rows[rowId].Cells["SrNo"].Value = dgvBills.Rows.Count;
                        dgvBills.Rows[rowId].Cells["BillNo"].Value = litem.InvoiceNo;
                        dgvBills.Rows[rowId].Cells["BillDate"].Value = litem.InvoiceDate;
                        dgvBills.Rows[rowId].Cells["BillAmount"].Value = litem.NetAmt;
                        dgvBills.Rows[rowId].Cells["RecvAmount"].Value = "0";
                        dgvBills.Rows[rowId].Cells["DiscAmount"].Value = "0";
                        dgvBills.Rows[rowId].Cells["DueAmount"].Value = litem.DueAmt == null ? litem.NetAmt : litem.DueAmt;

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void dtpChqDate_Leave(object sender, EventArgs e)
        {
            dgvBills.CurrentCell = dgvBills.Rows[0].Cells[4];
        }

        private void dgvBills_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBills_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (dgvBills.CurrentRow == null) return;
                int lcurrentindx = dgvBills.CurrentRow.Index;
                if (lcurrentindx < dgvBills.Rows.Count - 1)
                    dgvBills.CurrentCell = dgvBills.Rows[lcurrentindx + 1].Cells[4];
            }

        }

        private void txtReceiptAmt_EditValueChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvBills.Rows.Count; i++)
            {
                dgvBills.Rows[i].Cells["RecvAmount"].Value = 0;
            }
            double lruntotal = AppFun.ToDouble(txtReceiptAmt.Text);
            for (int i = 0; i < dgvBills.Rows.Count; i++)
            {
                if (lruntotal <= 0) return;
                double ldueamt = AppFun.ToDouble(dgvBills.Rows[i].Cells["DueAmount"].Value.ToString());
                if (ldueamt <= lruntotal)
                {
                    dgvBills.Rows[i].Cells["RecvAmount"].Value = AppFun.ToDouble(ldueamt.ToString());
                }
                else
                {
                    dgvBills.Rows[i].Cells["RecvAmount"].Value = AppFun.ToDouble(lruntotal.ToString());
                }
                lruntotal = lruntotal -  AppFun.ToDouble(dgvBills.Rows[i].Cells["RecvAmount"].Value.ToString());
            }
        }




    }
}