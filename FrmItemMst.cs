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
    public partial class FrmItemMst : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public int mPkValue = 0;
        public FrmItemMst()
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
            HelperClass.bCombBox_Unit(cmbUnit);
            HelperClass.bCombBox_Taxes(cmbTax);
        }
        void LoadData()
        {
            if (mPkValue > 0)
            {
                //var lqry = dbx.ItemMsts.Where(u => u.ItemId == mPkValue).FirstOrDefault();

                var lqry = (from i in dbx.ItemMsts
                            join t in dbx.TaxMsts on i.TaxId equals t.TaxId
                            where i.ItemId == mPkValue
                            select new
                            {
                                i.ItemName,
                                i.ItemCode,
                                i.Unit,
                                i.ItemDesc,
                                t.TaxName,
                                i.IGSTPer,
                                i.CGSTPer,
                                i.SGSTPer,
                                i.PurchasePrice,
                                i.SalePrice,
                                i.HSNCode

                            }).FirstOrDefault();
                if (lqry != null)
                {
                    txtItemName.Text = lqry.ItemName;
                    txtItemCode.Text = lqry.ItemCode;
                    cmbUnit.Text = lqry.Unit;
                    txtItemDesc.Text = lqry.ItemDesc;
                    cmbTax.Text = lqry.TaxName.ToString();
                    txtIGST.Text = lqry.IGSTPer.ToString();
                    txtCGST.Text = lqry.CGSTPer.ToString();
                    txtSGST.Text = lqry.SGSTPer.ToString();
                    txtPurchasePrice.Text = lqry.PurchasePrice.ToString();
                    txtSalePrice.Text = lqry.SalePrice.ToString();
                    txtHSNCode.Text = lqry.HSNCode;
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
            if (txtItemName.Text.Length == 0)
            {
                MessageBox.Show("Kindly enter item name.");
                txtItemName.Focus();
                return;
            }
            if (cmbTax.Text.Length == 0)
            {
                MessageBox.Show("Kindly select tax.");
                cmbTax.Focus();
                return;
            }

            cmbTax.Tag = dbx.TaxMsts.Where(u => u.TaxName == cmbTax.Text.Trim()).Select(s=> s.TaxId).FirstOrDefault();

            if (mPkValue == 0)
            {
                ItemMst objitm = new ItemMst();

                objitm.ItemName = txtItemName.Text;
                objitm.ItemCode = txtItemCode.Text;
                objitm.Unit = cmbUnit.Text;
                objitm.ItemDesc = txtItemDesc.Text;
                objitm.TaxId = Convert.ToInt32(cmbTax.Tag);
                objitm.IGSTPer = AppFun.ToDecimal(txtIGST.Text);
                objitm.CGSTPer = AppFun.ToDecimal(txtCGST.Text);
                objitm.SGSTPer = AppFun.ToDecimal(txtSGST.Text);
                objitm.PurchasePrice = AppFun.ToDecimal(txtPurchasePrice.Text);
                objitm.SalePrice = AppFun.ToDecimal(txtSalePrice.Text);
                objitm.HSNCode = txtHSNCode.Text;

                dbx.ItemMsts.Add(objitm);
                dbx.SaveChanges();

                MessageBox.Show("Item detail saved..");
            }
            else
            {
                var objitm = dbx.ItemMsts.Where(u => u.ItemId == mPkValue).First();
                if (objitm != null)
                {
                    objitm.ItemName = txtItemName.Text;
                    objitm.ItemCode = txtItemCode.Text;
                    objitm.Unit = cmbUnit.Text;
                    objitm.ItemDesc = txtItemDesc.Text;
                    objitm.TaxId = Convert.ToInt32(cmbTax.Tag);
                    objitm.IGSTPer = Convert.ToDecimal(txtIGST.Text);
                    objitm.CGSTPer = Convert.ToDecimal(txtCGST.Text);
                    objitm.SGSTPer = Convert.ToDecimal(txtSGST.Text);
                    objitm.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
                    objitm.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
                    objitm.HSNCode = txtHSNCode.Text;

                    dbx.SaveChanges();
                    MessageBox.Show("Item detail updated..");
                }

            }

            var lqryu = dbx.UnitMsts.Where(u => u.UnitName == cmbUnit.Text.Trim());
            if (lqryu.Count() == 0)
            {
                UnitMst objumt = new UnitMst();
                objumt.UnitName = cmbUnit.Text;
                dbx.UnitMsts.Add(objumt);
                dbx.SaveChanges();
                HelperClass.bCombBox_Unit(cmbUnit);
            }
            ClearControls();

        }
        void ClearControls()
        {
            txtItemName.Text = "";
            txtItemCode.Text = "";
            cmbUnit.Text = "";
            txtItemDesc.Text = "";
            cmbTax.Text = "";
            txtIGST.Text = "0";
            txtCGST.Text = "0";
            txtSGST.Text = "0";
            txtPurchasePrice.Text = "0";
            txtSalePrice.Text = "0";
            txtHSNCode.Text = "";
            txtItemName.Focus();

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            FrmItemList objclist = new FrmItemList();
            objclist.ShowDialog();
        }



        private void FrmCustomerMst_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbTax_Leave(object sender, EventArgs e)
        {
            try
            {
                var lqry = dbx.TaxMsts.Where(u => u.TaxName == cmbTax.Text.Trim()).FirstOrDefault();
                if (lqry != null)
                {
                    txtIGST.Text = lqry.IGST.ToString();
                    txtCGST.Text = lqry.CGST.ToString();
                    txtSGST.Text = lqry.SGST.ToString();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}