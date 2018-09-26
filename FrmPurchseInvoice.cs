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
    public partial class FrmPurchseInvoice : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        bool mTaxItemLevel = false;
        public int mPkValue = 0;
        int mFormActionMode;
        public bool mbDataLoaded = false;
        public FrmPurchseInvoice()
        {
            InitializeComponent();

        }
        enum FormAction { Add = 0, Edit = 1, Delete = 2 }
        enum InvoiceType { Credit, Cash }
        enum GstType { IGST, CGST_SGST }
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
            doSetGSTControls();
            cmbInvoiceType_Leave(sender, e);
            mFormActionMode = Convert.ToInt32(FormAction.Add);
        }

        void doSetControls()
        {
            bool isItemNameHelp = AppInit.SoftwareSettings.Inv_invoiceItemHelpValue;

            mTaxItemLevel = AppInit.SoftwareSettings.Inv_invoiceTaxonTotalLevelValue;

            if (mTaxItemLevel)
            {
                LblDiscPer.Visible = false;
                LblDiscAmt.Visible = false;
                txtDiscPer.Visible = false;
                txtDiscAmt.Visible = false;
            }
            else
            {
                LblDiscPer.Visible = true;
                LblDiscAmt.Visible = true;
                txtDiscPer.Visible = true;
                txtDiscAmt.Visible = true;
            }
            if (isItemNameHelp)
            {
                slkp_ItemName.Visible = true;
                txtItemName.Visible = false;
                this.tableLayoutPanel2.Controls.Add(this.slkp_ItemName, 0, 1);
                slkp_ItemName.TabIndex = 0;
            }
            else
            {
                slkp_ItemName.Visible = false;
                txtItemName.Visible = true;
                this.tableLayoutPanel2.Controls.Add(this.txtItemName, 0, 1);
                txtItemName.TabIndex = 0;
            }

            if (AppInit.SoftwareSettings.Inv_EnableOth1AddValue)
            {
                lblOth1Add.Visible = true;
                txtOth1AddPer.Visible = true;
                txtOth1AddAmt.Visible = true;
            }

            if (AppInit.SoftwareSettings.Inv_EnableShippingDetailValue)
            { PnlShippingDetails.Visible = true; }
            else { PnlShippingDetails.Visible = false; }

            cmbInvoiceType.Properties.Items.Clear();
            cmbInvoiceType.Properties.Items.Add(InvoiceType.Credit.ToString());
            cmbInvoiceType.Properties.Items.Add(InvoiceType.Cash.ToString());

            cmbGSTType.Properties.Items.Clear();
            cmbGSTType.Properties.Items.Add(GstType.IGST.ToString());
            cmbGSTType.Properties.Items.Add(GstType.CGST_SGST.ToString());

            cmbInvoiceType.Text = InvoiceType.Credit.ToString();

            dtpInvDate.EditValue = DateTime.Now.Date.ToLongDateString();
            dtpInvDueDate.EditValue = DateTime.Now.Date.ToLongDateString();

            dtpOrderDate.Properties.NullText = "";
            dtpChallanDate.Properties.NullText = "";

            txtCreditDays.Text = "0";
            //HelperClass.bCombBox_Taxes(cmbTotalLevelTax);
            //HelperClass.bCombBox_Taxes(cmbItemLevelTax);
            HelperClass.SearchLkp_Suppliers(LkpSupplierName);
            HelperClass.SearchLkp_Items(slkp_ItemName);
            HelperClass.bCombBox_Unit(CmbUnit);
            HelperClass.SearchLkp_Book(cmbBook, "P");
            var lqry = (from c in dbx.TaxMsts select new { c.TaxId, c.TaxName }).ToList();
            cmbTotalLevelTax.Properties.DataSource = lqry;
            cmbTotalLevelTax.Properties.DisplayMember = "TaxName";
            cmbTotalLevelTax.Properties.ValueMember = "TaxId";
            cmbTotalLevelTax.Properties.PopulateColumns();
            cmbTotalLevelTax.Properties.Columns["TaxId"].Visible = false;

            cmbItemLevelTax.Properties.DataSource = lqry;
            cmbItemLevelTax.Properties.DisplayMember = "TaxName";
            cmbItemLevelTax.Properties.ValueMember = "TaxId";
            cmbItemLevelTax.Properties.PopulateColumns();
            cmbItemLevelTax.Properties.Columns["TaxId"].Visible = false;
            ItemLoadData();

            //GatMaxInvNo();
        }
        void doSetGSTControls()
        {
            try
            {


                lblTotalLevelTax.Visible = false;
                cmbTotalLevelTax.Visible = false;
                lblItemLevelTax.Visible = false;
                cmbItemLevelTax.Visible = false;

                /// item level tax controls
                lblIGSTPer.Visible = false;
                txtIGSTPer.Visible = false;
                lblIGSTAmt.Visible = false;
                txtIGSTAmt.Visible = false;

                lblCGSTPer.Visible = false;
                txtCGSTPer.Visible = false;
                lblCGSTAmt.Visible = false;
                txtCGSTAmt.Visible = false;

                lblSGSTPer.Visible = false;
                txtSGSTPer.Visible = false;
                lblSGSTAmt.Visible = false;
                txtSGSTAmt.Visible = false;

                // total level tax controls

                lblT_IGST.Visible = false;
                txtT_IGSTPer.Visible = false;
                txtT_IGSTAmt.Visible = false;

                lblT_CGST.Visible = false;
                txtT_CGSTPer.Visible = false;
                txtT_CGSTAmt.Visible = false;

                lblT_SGST.Visible = false;
                txtT_SGSTPer.Visible = false;
                txtT_SGSTAmt.Visible = false;

                dgvItems.Columns["IGSTPer"].Visible = false;
                dgvItems.Columns["IGSTAmt"].Visible = false;
                dgvItems.Columns["CGSTPer"].Visible = false;
                dgvItems.Columns["CGSTAmt"].Visible = false;
                dgvItems.Columns["SGSTPer"].Visible = false;
                dgvItems.Columns["SGSTAmt"].Visible = false;

                if (mTaxItemLevel)
                {

                    lblItemLevelTax.Visible = true;
                    cmbItemLevelTax.Visible = true;
                }
                else
                {
                    lblTotalLevelTax.Visible = true;
                    cmbTotalLevelTax.Visible = true;

                    //txtT_IGSTPer.Visible = true;
                    //txtT_IGSTAmt.Enabled = true;
                    //txtT_CGSTPer.Visible = true;
                    //txtT_CGSTAmt.Enabled = true;
                    //txtT_SGSTPer.Visible = true;
                    //txtT_SGSTAmt.Enabled = true;
                }
                if (cmbInvoiceType.Text == InvoiceType.Credit.ToString())
                {
                    if (LkpSupplierName.Tag.ToString().Trim().Length == 0) return;
                }
                else
                {
                    LkpSupplierName.Tag = 0;
                }
                if (AppInit.CompanyInfo.CompanyStateCode == LkpSupplierName.Tag.ToString().Trim() || cmbInvoiceType.Text == InvoiceType.Cash.ToString())
                {
                    cmbGSTType.Text = GstType.CGST_SGST.ToString();
                    dgvItems.Columns["CGSTPer"].Visible = true;
                    dgvItems.Columns["CGSTAmt"].Visible = true;
                    dgvItems.Columns["SGSTPer"].Visible = true;
                    dgvItems.Columns["SGSTAmt"].Visible = true;
                    if (mTaxItemLevel)
                    {

                        lblCGSTPer.Visible = true;
                        lblCGSTAmt.Visible = true;
                        txtCGSTPer.Visible = true;
                        txtCGSTAmt.Visible = true;

                        lblSGSTPer.Visible = true;
                        lblSGSTAmt.Visible = true;
                        txtSGSTPer.Visible = true;
                        txtSGSTAmt.Visible = true;

                        lblT_CGST.Visible = true;
                        txtT_CGSTAmt.Visible = true; txtT_CGSTAmt.Enabled = false;

                        lblT_SGST.Visible = true;
                        txtT_SGSTAmt.Visible = true; txtT_SGSTAmt.Enabled = false;

                    }
                    else
                    {
                        lblT_CGST.Visible = true;
                        lblT_SGST.Visible = true;

                        txtT_CGSTPer.Visible = true;
                        txtT_CGSTAmt.Visible = true;
                        txtT_SGSTPer.Visible = true;
                        txtT_SGSTAmt.Visible = true;
                    }
                }
                else
                {
                    cmbGSTType.Text = GstType.IGST.ToString();
                    dgvItems.Columns["IGSTPer"].Visible = true;
                    dgvItems.Columns["IGSTAmt"].Visible = true;
                    if (mTaxItemLevel)
                    {
                        lblIGSTPer.Visible = true;
                        lblIGSTAmt.Visible = true;
                        txtIGSTPer.Visible = true;
                        txtIGSTAmt.Visible = true;

                        lblT_IGST.Visible = true;
                        txtT_IGSTAmt.Visible = true; txtT_IGSTAmt.Enabled = false;
                    }
                    else
                    {
                        lblT_IGST.Visible = true;
                        txtT_IGSTPer.Visible = true;
                        txtT_IGSTAmt.Visible = true;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        void ItemLoadData()
        {
            try
            {

                //var lqry = dbx.InvoiceDets.Where(u => 1 == 2).ToList();
                //xItemGrid.DataSource = lqry;

                //xItemDetGrid.Columns["InvDetId"].Visible = false;
                //xItemDetGrid.Columns["InvId"].Visible = false;
                //xItemDetGrid.Columns["ItemId"].Visible = false;
                //xItemDetGrid.Columns["ItemTaxId"].Visible = false;
                //xItemDetGrid.Columns["TaxableAmt"].Visible = false;

                //xItemDetGrid.Columns["ItemDiscountPer"].Caption = "Disc %";
                //xItemDetGrid.Columns["ItemDiscountAmt"].Caption = "Disc Amt";

                //xItemDetGrid.Columns["ItemIGstPer"].Caption = "IGST %";
                //xItemDetGrid.Columns["ItemIGstAmt"].Caption = "IGST Amt";
                //xItemDetGrid.Columns["ItemCGstPer"].Caption = "CGST %";
                //xItemDetGrid.Columns["ItemCGstAmt"].Caption = "CGST Amt";
                //xItemDetGrid.Columns["ItemSGstPer"].Caption = "SGST %";
                //xItemDetGrid.Columns["ItemSGstAmt"].Caption = "SGST Amt";

                //xItemDetGrid.Columns["ItemAmount"].Caption = "Amount";



                //var lqitm = HelperClass.glkp_Item();
                //repItem_Item_glkp.DataSource = lqitm;
                //xItemDetGrid.Columns["ItemName"].ColumnEdit = repItem_Item_glkp;

                //xItemDetGrid.AddNewRow();


            }
            catch (Exception)
            {

            }
        }
        void GatMaxInvNo()
        {
            //if (mFormActionMode == Convert.ToInt32(FormAction.Edit)) return;
            //var lqry = dbx.InvoiceMsts.OrderByDescending(u => u.InvId).Take(1).FirstOrDefault();

            //if (lqry == null)
            //{
            //    txtInvoiceNo.Text = "1";
            //    txtInvoiceNo.Tag = "1";
            //}
            //else
            //{
            //    txtInvoiceNo.Text = (lqry.InvNo + 1).ToString();
            //    txtInvoiceNo.Tag = (lqry.InvNo + 1).ToString();
            //}

            if (mFormActionMode == Convert.ToInt32(FormAction.Edit)) return;
            int lbookid = Convert.ToInt32(cmbBook.EditValue);
            var lqry = dbx.BookMsts.Where(u => u.BookId == lbookid && u.TranType == "P").FirstOrDefault();
            string lprefix = lqry.Prefix == null ? "" : lqry.Prefix;
            int linvno = Convert.ToInt32(lqry.InvNo);

            var lqry1 = dbx.PurInvoiceMsts.Where(u => u.BookId == lbookid ).OrderByDescending(d => d.InvNo).Take(1).FirstOrDefault();

            if (lqry1 == null)
            {

                txtInvoiceNo.Text = lprefix.Length == 0 ? lprefix + (linvno).ToString() : lprefix + "-" + (linvno).ToString();
                txtInvoiceNo.Tag = (linvno + 1);
            }
            else
            {
                if (linvno <= lqry1.InvNo)
                {
                    txtInvoiceNo.Text = lprefix.Length == 0 ? lprefix + (lqry1.InvNo + 1).ToString() : "" + lprefix + "-" + (lqry1.InvNo + 1).ToString();
                    txtInvoiceNo.Tag = (lqry1.InvNo + 1).ToString();
                }
                else
                {
                    txtInvoiceNo.Text = lprefix.Length == 0 ? lprefix + (lqry1.InvNo + 1).ToString() : "" + lprefix + "-" + linvno.ToString();
                    txtInvoiceNo.Tag = linvno;
                }
            }
            txtInvoiceNo.DeselectAll();

        }
        void LoadData()
        {
            if (mPkValue > 0 && mbDataLoaded == false)
            {
                mFormActionMode = Convert.ToInt32(FormAction.Edit);
                var lqry = dbx.PurInvoiceMsts.Where(u => u.InvId == mPkValue).FirstOrDefault();
                if (lqry != null)
                {
                    cmbInvoiceType.Text = lqry.InvoiceType;
                    txtInvoiceNo.Text = lqry.InvoiceNo;
                    txtBillNo.Text = lqry.BillNo;
                    txtInvoiceNo.Tag = lqry.InvNo.ToString();
                    dtpInvDate.EditValue = Convert.ToDateTime(lqry.InvoiceDate);
                    cmbTotalLevelTax.EditValue = lqry.TotalLevelTaxId;
                    LkpSupplierName.EditValue = lqry.SupplierId;
                    LkpSupplierName.Tag = dbx.CustomerMsts.Find(lqry.SupplierId).StateCode.ToString();
                    txtCustomerName.Text = lqry.SupplierName;
                    txtAddress.Text = lqry.Address;
                    cmbGSTType.Text = lqry.GSTType;
                    txtCreditDays.Text = lqry.CreditDays.ToString();
                    dtpInvDueDate.EditValue = Convert.ToDateTime(lqry.DueDate);
                    txtRemark.Text = lqry.Remark;

                    txtTotal.Text = lqry.TotalAmt.ToString();
                    txtT_IGSTPer.Text = lqry.IGstPer.ToString();
                    txtT_IGSTAmt.Text = lqry.IGstAmt.ToString();
                    txtT_CGSTPer.Text = lqry.CGstPer.ToString();
                    txtT_CGSTAmt.Text = lqry.CGstAmt.ToString();
                    txtT_SGSTPer.Text = lqry.SGstPer.ToString();
                    txtT_SGSTAmt.Text = lqry.SGstAmt.ToString();

                    txtT_FreightPer.Text = lqry.FreightPer.ToString();
                    txtT_FreightAmt.Text = lqry.FreightAmt.ToString();
                    txtT_PackingPer.Text = lqry.PackingPer.ToString();
                    txtT_PackingAmt.Text = lqry.PackingAmt.ToString();
                    txtT_DiscountPer.Text = lqry.DiscountPer.ToString();
                    txtT_DiscountAmt.Text = lqry.DiscountAmt.ToString();
                    txtOrderNo.Text = lqry.OrderNo;
                    txtChallanNo.Text = lqry.ChallanNo;
                    dtpOrderDate.EditValue = Convert.ToDateTime(lqry.OrderDate);
                    dtpChallanDate.EditValue = Convert.ToDateTime(lqry.ChallanDate);
                    txtLrNo.Text = lqry.LrNo;
                    txtTransporterName.Text = lqry.TransporterName;
                    txtVehicleNo.Text = lqry.VehicleNo;
                    txtNetInvoiceAmt.Text = lqry.NetAmt.ToString();

                    txtOth1AddPer.Text = lqry.Oth1_AddPer.ToString();
                    txtOth1AddAmt.Text = lqry.Oth1_AddAmt.ToString();
                    if (Convert.ToBoolean(lqry.GSTTotalLevel))
                        mTaxItemLevel = false;
                    else
                        mTaxItemLevel = true;

                    var ldqry = dbx.PurInvoiceDets.Where(u => u.InvId == mPkValue).ToList();
                    if (ldqry != null)
                    {
                        foreach (var item in ldqry)
                        {

                            int rowId = dgvItems.Rows.Add();
                            dgvItems.Rows[rowId].Cells["SrNo"].Value = dgvItems.Rows.Count;
                            dgvItems.Rows[rowId].Cells["ItemId"].Value = item.ItemId;
                            dgvItems.Rows[rowId].Cells["ItemName"].Value = item.ItemName;
                            dgvItems.Rows[rowId].Cells["ItemDesc"].Value = item.ItemDesc;
                            dgvItems.Rows[rowId].Cells["HSNCode"].Value = item.HSNCode;
                            dgvItems.Rows[rowId].Cells["Unit"].Value = item.Unit;
                            dgvItems.Rows[rowId].Cells["Qty"].Value = item.Qty.ToString();
                            dgvItems.Rows[rowId].Cells["Rate"].Value = item.Rate.ToString();
                            dgvItems.Rows[rowId].Cells["DiscPer"].Value = item.ItemDiscountPer.ToString();
                            dgvItems.Rows[rowId].Cells["DiscAmt"].Value = item.ItemDiscountAmt.ToString();
                            dgvItems.Rows[rowId].Cells["TaxableAmt"].Value = item.TaxableAmt.ToString();
                            dgvItems.Rows[rowId].Cells["TaxId"].Value = item.ItemTaxId;
                            cmbItemLevelTax.EditValue = item.ItemTaxId;
                            dgvItems.Rows[rowId].Cells["TaxName"].Value = cmbItemLevelTax.Text;
                            dgvItems.Rows[rowId].Cells["IGSTPer"].Value = item.ItemIGstPer.ToString();
                            dgvItems.Rows[rowId].Cells["IGSTAmt"].Value = item.ItemIGstAmt.ToString();
                            dgvItems.Rows[rowId].Cells["CGSTPer"].Value = item.ItemCGstPer.ToString();
                            dgvItems.Rows[rowId].Cells["CGSTAmt"].Value = item.ItemCGstAmt.ToString();
                            dgvItems.Rows[rowId].Cells["SGSTPer"].Value = item.ItemSGstPer.ToString();
                            dgvItems.Rows[rowId].Cells["SGSTAmt"].Value = item.ItemSGstAmt.ToString();
                            dgvItems.Rows[rowId].Cells["Amount"].Value = item.ItemAmount.ToString();

                        }
                    }
                    doSetGSTControls();
                    calNetAmt();
                    mbDataLoaded = true;
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
            if (txtCustomerName.Text.Length == 0 && cmbInvoiceType.Text == InvoiceType.Cash.ToString())
            {
                MessageBox.Show("Kindly enter Supplier name.");
                txtCustomerName.Focus();
                return;
            }
            else if (LkpSupplierName.EditValue == null && cmbInvoiceType.Text == InvoiceType.Credit.ToString())
            {
                MessageBox.Show("Kindly select supplier name.");
                LkpSupplierName.Focus();
                return;
            }
            if (!mTaxItemLevel && cmbTotalLevelTax.Text == "")
            {
                MessageBox.Show("Kindly select Tax code.");
                cmbTotalLevelTax.Focus();
                return;
            }
            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Enter a item details.");
                cmbTotalLevelTax.Focus();
                return;
            }
            if (cmbGSTType.Text.Length == 0)
            {
                MessageBox.Show("Select GST Type");
                cmbGSTType.Focus();
                return;
            }
            calReverseItemLevelTax();
            int lstoreinvid = 0;
            if (mPkValue == 0)
            {

                PurInvoiceMst objimst = new PurInvoiceMst();

                objimst.InvoiceType = cmbInvoiceType.Text;
                objimst.InvoiceNo = txtInvoiceNo.Text;
                objimst.BillNo = txtBillNo.Text;
                objimst.InvNo = Convert.ToInt32(txtInvoiceNo.Tag);
                
                objimst.InvoiceDate = Convert.ToDateTime(dtpInvDate.Text);
                if (cmbTotalLevelTax.Visible)
                    objimst.TotalLevelTaxId = Convert.ToInt32(cmbTotalLevelTax.EditValue);
                else
                    objimst.TotalLevelTaxId = 0;
                objimst.SupplierId = Convert.ToInt32(LkpSupplierName.EditValue);
                if (cmbInvoiceType.Text == InvoiceType.Cash.ToString())
                    objimst.SupplierName = txtCustomerName.Text;
                else
                    objimst.SupplierName = LkpSupplierName.Text;
                objimst.Address = txtAddress.Text;
                objimst.GSTType = cmbGSTType.Text;
                objimst.CreditDays = Convert.ToInt32(txtCreditDays.Text);
                objimst.DueDate = Convert.ToDateTime(dtpInvDueDate.Text);
                objimst.Remark = txtRemark.Text;

                objimst.TotalAmt = AppFun.ToDecimal(txtTotal.Text);
                objimst.IGstPer = AppFun.ToDecimal(txtT_IGSTPer.Text);
                objimst.IGstAmt = AppFun.ToDecimal(txtT_IGSTAmt.Text);
                objimst.CGstPer = AppFun.ToDecimal(txtT_CGSTPer.Text);
                objimst.CGstAmt = AppFun.ToDecimal(txtT_CGSTAmt.Text);
                objimst.SGstPer = AppFun.ToDecimal(txtT_SGSTPer.Text);
                objimst.SGstAmt = AppFun.ToDecimal(txtT_SGSTAmt.Text);
                //MessageBox.Show("Test2");
                objimst.FreightPer = AppFun.ToDecimal(txtT_FreightPer.Text);
                objimst.FreightAmt = AppFun.ToDecimal(txtT_FreightAmt.Text);

                objimst.PackingPer = AppFun.ToDecimal(txtT_PackingPer.Text);
                objimst.PackingAmt = AppFun.ToDecimal(txtT_PackingAmt.Text);

                objimst.DiscountPer = AppFun.ToDecimal(txtT_DiscountPer.Text);
                objimst.DiscountAmt = AppFun.ToDecimal(txtT_DiscountAmt.Text);
                objimst.OrderNo = txtOrderNo.Text;
                objimst.ChallanNo = txtChallanNo.Text;
                objimst.OrderDate = Convert.ToDateTime(dtpOrderDate.EditValue);
                objimst.ChallanDate = Convert.ToDateTime(dtpChallanDate.EditValue);

                if (objimst.OrderDate.ToString() == "01/01/0001 00:00:00")
                {
                    objimst.OrderDate = null;
                }
                if (objimst.ChallanDate.ToString() == "01/01/0001 00:00:00")
                {
                    objimst.ChallanDate = null;
                }
                objimst.LrNo = txtLrNo.Text;
                objimst.VehicleNo = txtVehicleNo.Text;
                objimst.TransporterName = txtTransporterName.Text;
                objimst.BookId = Convert.ToInt32(cmbBook.EditValue);

                objimst.NetAmt = AppFun.ToDecimal(txtNetInvoiceAmt.Text);
                objimst.Oth1_AddTag = lblOth1Add.Text;
                objimst.Oth1_AddPer = AppFun.ToDecimal(txtOth1AddPer.Text);
                objimst.Oth1_AddAmt = AppFun.ToDecimal(txtOth1AddAmt.Text);

                if (mTaxItemLevel)
                    objimst.GSTTotalLevel = false;
                else
                    objimst.GSTTotalLevel = true;

                dbx.PurInvoiceMsts.Add(objimst);


                dbx.SaveChanges();

                lstoreinvid = objimst.InvId;

                PurInvoiceDet objidet = new PurInvoiceDet();
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    objidet.InvId = objimst.InvId;
                    objidet.ItemId = Convert.ToInt32(dgvItems.Rows[i].Cells["ItemId"].Value);
                    objidet.ItemName = dgvItems.Rows[i].Cells["ItemName"].Value.ToString();
                    if (dgvItems.Rows[i].Cells["ItemDesc"].Value != null)
                        objidet.ItemDesc = dgvItems.Rows[i].Cells["ItemDesc"].Value.ToString();
                    if (dgvItems.Rows[i].Cells["HSNCode"].Value != null)
                        objidet.HSNCode = dgvItems.Rows[i].Cells["HSNCode"].Value.ToString();
                    objidet.Unit = dgvItems.Rows[i].Cells["Unit"].Value.ToString();
                    objidet.Qty = AppFun.ToDecimal(dgvItems.Rows[i].Cells["Qty"].Value.ToString());
                    objidet.Rate = AppFun.ToDecimal(dgvItems.Rows[i].Cells["Rate"].Value.ToString());
                    objidet.ItemDiscountPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["DiscPer"].Value.ToString());
                    objidet.ItemDiscountAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["DiscAmt"].Value.ToString());
                    objidet.TaxableAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["TaxableAmt"].Value.ToString());
                    objidet.ItemTaxId = Convert.ToInt32(dgvItems.Rows[i].Cells["TaxId"].Value.ToString());

                    objidet.ItemIGstPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["IGSTPer"].Value.ToString());
                    objidet.ItemIGstAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                    objidet.ItemCGstPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["CGSTPer"].Value.ToString());
                    objidet.ItemCGstAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["CGSTAmt"].Value.ToString());
                    objidet.ItemSGstPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["SGSTPer"].Value.ToString());
                    objidet.ItemSGstAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["SGSTAmt"].Value.ToString());
                    objidet.ItemAmount = AppFun.ToDecimal(dgvItems.Rows[i].Cells["Amount"].Value.ToString());

                    dbx.PurInvoiceDets.Add(objidet);
                    dbx.SaveChanges();


                }

                MessageBox.Show("Invoice detail saved..");
            }
            else
            {
                var objimst = dbx.PurInvoiceMsts.Where(u => u.InvId == mPkValue).First();
                if (objimst != null)
                {
                    objimst.InvoiceType = cmbInvoiceType.Text;
                    objimst.InvoiceNo = txtInvoiceNo.Text;
                    objimst.BillNo = txtBillNo.Text;
                    objimst.InvNo = Convert.ToInt32(txtInvoiceNo.Tag);
                    objimst.InvoiceDate = Convert.ToDateTime(dtpInvDate.Text);
                    if (cmbTotalLevelTax.Visible)
                        objimst.TotalLevelTaxId = Convert.ToInt32(cmbTotalLevelTax.EditValue);
                    else
                        objimst.TotalLevelTaxId = 0;
                    objimst.SupplierId = Convert.ToInt32(LkpSupplierName.EditValue);
                    if (cmbInvoiceType.Text == InvoiceType.Cash.ToString())
                        objimst.SupplierName = txtCustomerName.Text;
                    else
                        objimst.SupplierName = LkpSupplierName.Text;
                    objimst.Address = txtAddress.Text;
                    objimst.GSTType = cmbGSTType.Text;
                    objimst.CreditDays = Convert.ToInt32(txtCreditDays.Text);
                    objimst.DueDate = Convert.ToDateTime(dtpInvDueDate.Text);
                    objimst.Remark = txtRemark.Text;

                    objimst.TotalAmt = AppFun.ToDecimal(txtTotal.Text);
                    objimst.IGstPer = AppFun.ToDecimal(txtT_IGSTPer.Text);
                    objimst.IGstAmt = AppFun.ToDecimal(txtT_IGSTAmt.Text);
                    objimst.CGstPer = AppFun.ToDecimal(txtT_CGSTPer.Text);
                    objimst.CGstAmt = AppFun.ToDecimal(txtT_CGSTAmt.Text);
                    objimst.SGstPer = AppFun.ToDecimal(txtT_SGSTPer.Text);
                    objimst.SGstAmt = AppFun.ToDecimal(txtT_SGSTAmt.Text);

                    objimst.FreightPer = AppFun.ToDecimal(txtT_FreightPer.Text);
                    objimst.FreightAmt = AppFun.ToDecimal(txtT_FreightAmt.Text);

                    objimst.PackingPer = AppFun.ToDecimal(txtT_PackingPer.Text);
                    objimst.PackingAmt = AppFun.ToDecimal(txtT_PackingAmt.Text);

                    objimst.DiscountPer = AppFun.ToDecimal(txtT_DiscountPer.Text);
                    objimst.DiscountAmt = AppFun.ToDecimal(txtT_DiscountAmt.Text);
                    objimst.OrderNo = txtOrderNo.Text;
                    objimst.ChallanNo = txtChallanNo.Text;
                    objimst.OrderDate = Convert.ToDateTime(dtpOrderDate.EditValue);
                    objimst.ChallanDate = Convert.ToDateTime(dtpChallanDate.EditValue);

                    if (objimst.OrderDate.ToString() == "01/01/0001 00:00:00")
                    {
                        objimst.OrderDate = null;
                    }
                    if (objimst.ChallanDate.ToString() == "01/01/0001 00:00:00")
                    {
                        objimst.ChallanDate = null;
                    }

                    objimst.LrNo = txtLrNo.Text;
                    objimst.VehicleNo = txtVehicleNo.Text;
                    objimst.TransporterName = txtTransporterName.Text;
                    objimst.BookId = Convert.ToInt32(cmbBook.EditValue);

                    objimst.NetAmt = AppFun.ToDecimal(txtNetInvoiceAmt.Text);
                    objimst.Oth1_AddTag = lblOth1Add.Text;
                    objimst.Oth1_AddPer = AppFun.ToDecimal(txtOth1AddPer.Text);
                    objimst.Oth1_AddAmt = AppFun.ToDecimal(txtOth1AddAmt.Text);
                    dbx.SaveChanges();
                    lstoreinvid = objimst.InvId;
                    var lqryd = dbx.PurInvoiceDets.Where(u => u.InvId == mPkValue).ToList();
                    foreach (var item in lqryd)
                    {
                        dbx.PurInvoiceDets.Remove(item);
                    }
                    dbx.SaveChanges();

                    PurInvoiceDet objidet = new PurInvoiceDet();
                    for (int i = 0; i < dgvItems.Rows.Count; i++)
                    {
                        objidet.InvId = objimst.InvId;
                        objidet.ItemId = Convert.ToInt32(dgvItems.Rows[i].Cells["ItemId"].Value);
                        objidet.ItemName = dgvItems.Rows[i].Cells["ItemName"].Value.ToString();
                        if (dgvItems.Rows[i].Cells["ItemDesc"].Value != null)
                            objidet.ItemDesc = dgvItems.Rows[i].Cells["ItemDesc"].Value.ToString();
                        if (dgvItems.Rows[i].Cells["HSNCode"].Value != null)
                            objidet.HSNCode = dgvItems.Rows[i].Cells["HSNCode"].Value.ToString();
                        objidet.Unit = dgvItems.Rows[i].Cells["Unit"].Value.ToString();
                        objidet.Qty = AppFun.ToDecimal(dgvItems.Rows[i].Cells["Qty"].Value.ToString());
                        objidet.Rate = AppFun.ToDecimal(dgvItems.Rows[i].Cells["Rate"].Value.ToString());
                        objidet.ItemDiscountPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["DiscPer"].Value.ToString());
                        objidet.ItemDiscountAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["DiscAmt"].Value.ToString());
                        objidet.TaxableAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["TaxableAmt"].Value.ToString());
                        objidet.ItemTaxId = Convert.ToInt32(dgvItems.Rows[i].Cells["TaxId"].Value.ToString());

                        objidet.ItemIGstPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["IGSTPer"].Value.ToString());
                        objidet.ItemIGstAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        objidet.ItemCGstPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["CGSTPer"].Value.ToString());
                        objidet.ItemCGstAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["CGSTAmt"].Value.ToString());
                        objidet.ItemSGstPer = AppFun.ToDecimal(dgvItems.Rows[i].Cells["SGSTPer"].Value.ToString());
                        objidet.ItemSGstAmt = AppFun.ToDecimal(dgvItems.Rows[i].Cells["SGSTAmt"].Value.ToString());
                        objidet.ItemAmount = AppFun.ToDecimal(dgvItems.Rows[i].Cells["Amount"].Value.ToString());

                        dbx.PurInvoiceDets.Add(objidet);
                        dbx.SaveChanges();


                    }
                    MessageBox.Show("Invoice detail updated..");
                }

            }

            ClearControls();



        }
        void ClearControls()
        {
            txtInvoiceNo.Text = "";
            txtBillNo.Text = "";
            cmbTotalLevelTax.EditValue = null;
            txtCustomerName.Text = "";
            LkpSupplierName.EditValue = null;
            txtAddress.Text = "";
            cmbGSTType.Text = "";
            txtCreditDays.Text = "0";

            txtRemark.Text = "";
            txtTotal.Text = "0";
            txtT_IGSTPer.Text = "0";
            txtT_IGSTAmt.Text = "0";
            txtT_CGSTPer.Text = "0";
            txtT_CGSTAmt.Text = "0";
            txtT_SGSTPer.Text = "0";
            txtT_SGSTAmt.Text = "0";

            txtT_FreightPer.Text = "0";
            txtT_FreightAmt.Text = "0";
            txtT_PackingPer.Text = "0";
            txtT_PackingAmt.Text = "0";
            txtT_DiscountPer.Text = "0";
            txtT_DiscountAmt.Text = "0";
            txtNetInvoiceAmt.Text = "0";
            txtOth1AddPer.Text = "0";
            txtOth1AddAmt.Text = "0";

            dtpChallanDate.EditValue = null;
            dtpOrderDate.EditValue = null;

            txtVehicleNo.Text = "";
            txtTransporterName.Text = "";
            txtLrNo.Text = "";
            txtTotal.Text = "0";
            txtNetInvoiceAmt.Text = "0";
            dgvItems.Rows.Clear();
            mFormActionMode = Convert.ToInt32(FormAction.Add);
            mPkValue = 0;
            cmbInvoiceType.Focus();

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            FrmPurchaseInvoiceList objilist = new FrmPurchaseInvoiceList();
            objilist.ShowDialog();
        }



        private void FrmCustomerMst_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void FrmCustomerMst_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbInvoiceType_Leave(object sender, EventArgs e)
        {

            if (cmbInvoiceType.Text == InvoiceType.Credit.ToString())
            {
                LkpSupplierName.Visible = true;
                txtCustomerName.Visible = false;
                pnlDueDate.Visible = true;
            }
            else
            {
                LkpSupplierName.Visible = false;
                txtCustomerName.Visible = true;
                pnlDueDate.Visible = false;
                doSetGSTControls();
            }
            //GatMaxInvNo();
        }

        private void cmbTotalLevelTax_Leave(object sender, EventArgs e)
        {
            try
            {
                var lqry = dbx.TaxMsts.Where(u => u.TaxName == cmbTotalLevelTax.Text.Trim()).FirstOrDefault();
                if (lqry != null)
                {
                    txtT_IGSTPer.Text = lqry.IGST.ToString();
                    txtT_CGSTPer.Text = lqry.CGST.ToString();
                    txtT_SGSTPer.Text = lqry.SGST.ToString();
                }
                calNetAmt();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LkpCustomerName_Leave(object sender, EventArgs e)
        {
            if (LkpSupplierName.Properties.View.FocusedRowHandle < 0) return;
            LkpSupplierName.Tag = LkpSupplierName.Properties.View.GetRowCellValue(LkpSupplierName.Properties.View.FocusedRowHandle, "StateCode").ToString();

            var lqry = dbx.CustomerMsts.Find(LkpSupplierName.EditValue);
            if (lqry != null)
            {
                txtAddress.Text = lqry.Address;
                txtAddress.DeselectAll();
            }
            doSetGSTControls();
        }

        private void slkp_ItemName_Leave(object sender, EventArgs e)
        {
            txtHSNCode.Text = "";
            if (slkp_ItemName.EditValue == null) return;
            if (mFormActionMode == Convert.ToInt32(FormAction.Add))
            {
                slkp_ItemName.Tag = slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "ItemId").ToString();
                CmbUnit.Text = slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "Unit").ToString();
                txtRate.Text = slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "SalePrice").ToString();
                cmbItemLevelTax.EditValue = Convert.ToInt32(slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "TaxId").ToString());
                txtHSNCode.Text = slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "HSNCode") == null ? "" : slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "HSNCode").ToString();
                txtitemdesc.Text = slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "HSNCode") == null ? "" : slkp_ItemName.Properties.View.GetRowCellValue(slkp_ItemName.Properties.View.FocusedRowHandle, "ItemDesc").ToString();
            }
        }

        private void cmbItemLevelTax_Leave(object sender, EventArgs e)
        {
            try
            {
                var lqry = dbx.TaxMsts.Where(u => u.TaxName == cmbItemLevelTax.Text.Trim()).FirstOrDefault();
                if (lqry != null)
                {
                    txtIGSTPer.Text = lqry.IGST.ToString();
                    txtCGSTPer.Text = lqry.CGST.ToString();
                    txtSGSTPer.Text = lqry.SGST.ToString();
                    CalculateItemLevelAmount();
                    calNetAmt();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtQty_EditValueChanged(object sender, EventArgs e)
        {
            CalculateItemLevelAmount();
        }

        private void txtRate_EditValueChanged(object sender, EventArgs e)
        {
            CalculateItemLevelAmount();
        }

        private void txtDiscPer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateItemLevelAmount();
        }

        private void txtIGSTPer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateItemLevelAmount();
        }

        private void txtCGSTPer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateItemLevelAmount();
        }

        private void txtSGSTPer_EditValueChanged(object sender, EventArgs e)
        {
            CalculateItemLevelAmount();
        }
        void CalculateItemLevelAmount()
        {
            double Rate_Qty = 0;

            double taxableamt = 0;

            Rate_Qty = AppFun.ToDouble(txtRate.Text) * AppFun.ToDouble(txtQty.Text);
            if (txtDiscPer.Text != "0")
            {
                txtDiscAmt.Text = HelperClass.CalPer(Rate_Qty, AppFun.ToDouble(txtDiscPer.Text)).ToString();
            }
            taxableamt = Rate_Qty - Convert.ToDouble(txtDiscAmt.Text);
            txtTaxableAMt.Text = taxableamt.ToString();
            if (cmbGSTType.Text == GstType.IGST.ToString())
            {
                txtIGSTAmt.Text = HelperClass.CalPer(taxableamt, AppFun.ToDouble(txtIGSTPer.Text)).ToString();
                txtCGSTAmt.Text = "0";
                txtSGSTAmt.Text = "0";
            }
            else
            {
                txtIGSTAmt.Text = "0";
                txtCGSTAmt.Text = HelperClass.CalPer(taxableamt, AppFun.ToDouble(txtCGSTPer.Text)).ToString();
                txtSGSTAmt.Text = HelperClass.CalPer(taxableamt, AppFun.ToDouble(txtSGSTPer.Text)).ToString();
            }

            txtItemAmount.Text = (taxableamt + AppFun.ToDouble(txtIGSTAmt.Text) + AppFun.ToDouble(txtCGSTAmt.Text) + AppFun.ToDouble(txtSGSTAmt.Text)).ToString();


        }
        void calNetAmt()
        {
            double lTotal = 0;
            double lIGst = 0;
            double lCGst = 0;
            double lSGst = 0;
            double lfreight = 0;
            double lPackingFrwrd = 0;
            double lDiscount = 0;
            double loth1add = 0;
            double lnetAmt = 0;

            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                lTotal += AppFun.ToDouble(dgvItems.Rows[i].Cells["TaxableAmt"].Value.ToString());
                if (mTaxItemLevel)
                {
                    lIGst += AppFun.ToDouble(dgvItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                    lCGst += AppFun.ToDouble(dgvItems.Rows[i].Cells["CGSTAmt"].Value.ToString());
                    lSGst += AppFun.ToDouble(dgvItems.Rows[i].Cells["SGSTAmt"].Value.ToString());
                }
            }

            if (!mTaxItemLevel)
            {
                if (cmbGSTType.Text == GstType.IGST.ToString())
                {
                    lIGst = HelperClass.CalPer(lTotal, AppFun.ToDouble(txtT_IGSTPer.Text));

                }
                else if (cmbGSTType.Text == GstType.CGST_SGST.ToString())
                {
                    lCGst = HelperClass.CalPer(lTotal, AppFun.ToDouble(txtT_CGSTPer.Text));
                    lSGst = HelperClass.CalPer(lTotal, AppFun.ToDouble(txtT_SGSTPer.Text));
                }
            }

            if (txtT_FreightPer.Text != "0")
            {
                lfreight = HelperClass.CalPer(lTotal, AppFun.ToDouble(txtT_FreightPer.Text));
            }
            else
            {
                lfreight = AppFun.ToDouble(txtT_FreightAmt.Text);
            }
            if (txtT_PackingPer.Text != "0")
            {
                lPackingFrwrd = HelperClass.CalPer(lTotal, AppFun.ToDouble(txtT_PackingPer.Text));
            }
            else
            {
                lPackingFrwrd = AppFun.ToDouble(txtT_PackingAmt.Text);
            }
            if (txtT_DiscountPer.Text != "0")
            {
                lDiscount = HelperClass.CalPer(lTotal, AppFun.ToDouble(txtT_DiscountPer.Text));
            }
            else
            {
                lDiscount = AppFun.ToDouble(txtT_DiscountAmt.Text);
            }
            if (txtOth1AddPer.Text != "0")
            {
                loth1add = HelperClass.CalPer(lTotal + lIGst + lCGst + lSGst + lfreight + lPackingFrwrd - lDiscount, AppFun.ToDouble(txtOth1AddPer.Text));
            }
            else
            {
                loth1add = AppFun.ToDouble(txtT_DiscountAmt.Text);
            }

            lnetAmt = lTotal + lIGst + lCGst + lSGst + lfreight + lPackingFrwrd + loth1add - lDiscount;
            txtTotal.Text = lTotal.ToString();
            txtT_IGSTAmt.Text = lIGst.ToString();
            txtT_CGSTAmt.Text = lCGst.ToString();
            txtT_SGSTAmt.Text = lSGst.ToString();

            txtT_FreightAmt.Text = lfreight.ToString();
            txtT_PackingAmt.Text = lPackingFrwrd.ToString();
            txtT_DiscountAmt.Text = lDiscount.ToString();
            txtOth1AddAmt.Text = loth1add.ToString();
            txtNetInvoiceAmt.Text = lnetAmt.ToString();



        }
        void calReverseItemLevelTax()
        {
            if (cmbTotalLevelTax.Visible)
            {
                double ltaxableamt = 0;
                double lIGst = 0;
                double lCGst = 0;
                double lSGst = 0;
                for (int i = 0; i < dgvItems.Rows.Count; i++)
                {
                    dgvItems.Rows[i].Cells["TaxId"].Value = cmbTotalLevelTax.EditValue;
                    if (cmbGSTType.Text == GstType.IGST.ToString())
                    {
                        ltaxableamt = AppFun.ToDouble(dgvItems.Rows[i].Cells["TaxableAmt"].Value.ToString());
                        lIGst = HelperClass.CalPer(ltaxableamt, AppFun.ToDouble(txtT_IGSTPer.Text));
                        dgvItems.Rows[i].Cells["IGSTPer"].Value = txtT_IGSTPer.Text;
                        dgvItems.Rows[i].Cells["IGSTAmt"].Value = lIGst.ToString();

                    }
                    else if (cmbGSTType.Text == GstType.CGST_SGST.ToString())
                    {
                        ltaxableamt = AppFun.ToDouble(dgvItems.Rows[i].Cells["TaxableAmt"].Value.ToString());
                        lCGst = HelperClass.CalPer(ltaxableamt, AppFun.ToDouble(txtT_CGSTPer.Text));
                        dgvItems.Rows[i].Cells["CGSTPer"].Value = txtT_CGSTPer.Text;
                        dgvItems.Rows[i].Cells["CGSTAmt"].Value = lCGst.ToString();

                        lSGst = HelperClass.CalPer(ltaxableamt, AppFun.ToDouble(txtT_SGSTPer.Text));
                        dgvItems.Rows[i].Cells["SGSTPer"].Value = txtT_SGSTPer.Text;
                        dgvItems.Rows[i].Cells["SGSTAmt"].Value = lSGst.ToString();
                    }
                }
            }
        }
        void ClearItemDetails()
        {
            txtItemName.Text = "";
            slkp_ItemName.EditValue = null;
            CmbUnit.Text = "";
            txtQty.Text = "0";
            txtRate.Text = "0";
            txtDiscPer.Text = "0";
            txtDiscAmt.Text = "0";
            txtTaxableAMt.Text = "0";
            txtIGSTPer.Text = "0";
            txtIGSTAmt.Text = "0";
            txtCGSTPer.Text = "0";
            txtCGSTAmt.Text = "0";
            txtSGSTPer.Text = "0";
            txtSGSTAmt.Text = "0";
            txtItemAmount.Text = "0";

        }
        bool mItemEditFlg = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (slkp_ItemName.Visible)
            {
                if (slkp_ItemName.EditValue == null)
                {
                    MessageBox.Show("Kindly select item.");
                    slkp_ItemName.Focus();
                    return;
                }
            }
            if (mItemEditFlg == false)
            {
                int rowId = dgvItems.Rows.Add();
                dgvItems.Rows[rowId].Cells["SrNo"].Value = dgvItems.Rows.Count;
                if (slkp_ItemName.Visible)
                {
                    dgvItems.Rows[rowId].Cells["ItemId"].Value = slkp_ItemName.EditValue;
                    dgvItems.Rows[rowId].Cells["ItemName"].Value = slkp_ItemName.Text;
                }
                else
                {
                    dgvItems.Rows[rowId].Cells["ItemId"].Value = "0";
                    dgvItems.Rows[rowId].Cells["ItemName"].Value = txtItemName.Text;
                }

                dgvItems.Rows[rowId].Cells["Unit"].Value = CmbUnit.Text;
                dgvItems.Rows[rowId].Cells["Qty"].Value = txtQty.Text;
                dgvItems.Rows[rowId].Cells["Rate"].Value = txtRate.Text;
                dgvItems.Rows[rowId].Cells["DiscPer"].Value = txtDiscPer.Text;
                dgvItems.Rows[rowId].Cells["DiscAmt"].Value = txtDiscAmt.Text;
                dgvItems.Rows[rowId].Cells["TaxableAmt"].Value = txtTaxableAMt.Text;
                dgvItems.Rows[rowId].Cells["TaxId"].Value = cmbItemLevelTax.EditValue;
                dgvItems.Rows[rowId].Cells["TaxName"].Value = cmbItemLevelTax.Text;
                dgvItems.Rows[rowId].Cells["IGSTPer"].Value = txtIGSTPer.Text;
                dgvItems.Rows[rowId].Cells["IGSTAmt"].Value = txtIGSTAmt.Text;
                dgvItems.Rows[rowId].Cells["CGSTPer"].Value = txtCGSTPer.Text;
                dgvItems.Rows[rowId].Cells["CGSTAmt"].Value = txtCGSTAmt.Text;
                dgvItems.Rows[rowId].Cells["SGSTPer"].Value = txtSGSTPer.Text;
                dgvItems.Rows[rowId].Cells["SGSTAmt"].Value = txtSGSTAmt.Text;
                dgvItems.Rows[rowId].Cells["Amount"].Value = txtItemAmount.Text;
                dgvItems.Rows[rowId].Cells["HSNCode"].Value = txtHSNCode.Text;
                dgvItems.Rows[rowId].Cells["ItemDesc"].Value = txtitemdesc.Text;


            }
            else
            {
                int rowId = dgvItems.CurrentCell.RowIndex;
                dgvItems.Rows[rowId].Cells["SrNo"].Value = rowId + 1;
                if (slkp_ItemName.Visible)
                {
                    dgvItems.Rows[rowId].Cells["ItemId"].Value = slkp_ItemName.EditValue;
                    dgvItems.Rows[rowId].Cells["ItemName"].Value = slkp_ItemName.Text;
                }
                else
                {
                    dgvItems.Rows[rowId].Cells["ItemId"].Value = "0";
                    dgvItems.Rows[rowId].Cells["ItemName"].Value = txtItemName.Text;
                }
                dgvItems.Rows[rowId].Cells["Unit"].Value = CmbUnit.Text;
                dgvItems.Rows[rowId].Cells["Qty"].Value = txtQty.Text;
                dgvItems.Rows[rowId].Cells["Rate"].Value = txtRate.Text;
                dgvItems.Rows[rowId].Cells["DiscPer"].Value = txtDiscPer.Text;
                dgvItems.Rows[rowId].Cells["DiscAmt"].Value = txtDiscAmt.Text;
                dgvItems.Rows[rowId].Cells["TaxableAmt"].Value = txtTaxableAMt.Text;
                dgvItems.Rows[rowId].Cells["TaxId"].Value = cmbItemLevelTax.EditValue;
                dgvItems.Rows[rowId].Cells["TaxName"].Value = cmbItemLevelTax.Text;
                dgvItems.Rows[rowId].Cells["IGSTPer"].Value = txtIGSTPer.Text;
                dgvItems.Rows[rowId].Cells["IGSTAmt"].Value = txtIGSTAmt.Text;
                dgvItems.Rows[rowId].Cells["CGSTPer"].Value = txtCGSTPer.Text;
                dgvItems.Rows[rowId].Cells["CGSTAmt"].Value = txtCGSTAmt.Text;
                dgvItems.Rows[rowId].Cells["SGSTPer"].Value = txtSGSTPer.Text;
                dgvItems.Rows[rowId].Cells["SGSTAmt"].Value = txtSGSTAmt.Text;
                dgvItems.Rows[rowId].Cells["Amount"].Value = txtItemAmount.Text;
                dgvItems.Rows[rowId].Cells["HSNCode"].Value = txtHSNCode.Text;
                dgvItems.Rows[rowId].Cells["ItemDesc"].Value = txtitemdesc.Text;
            }
            mItemEditFlg = false;
            dgvItems.Enabled = true;
            calNetAmt();
            ClearItemDetails();



            if (MessageBox.Show("want to add more item ?", "Alert", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (slkp_ItemName.Visible)
                {
                    slkp_ItemName.Focus();
                }
                else if (txtItemName.Visible)
                {
                    txtItemName.Focus();
                }
            }
            else
            {
                txtRemark.Focus();
            }


            //if (txtItemName.Visible) txtItemName.Focus();
            //else slkp_ItemName.Focus();
        }

        private void dgvItems_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {


            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mItemEditFlg = true;
            int rowId = e.RowIndex;

            if (slkp_ItemName.Visible == true)
                slkp_ItemName.EditValue = dgvItems.Rows[rowId].Cells["ItemId"].Value;
            else
                txtItemName.Text = dgvItems.Rows[rowId].Cells["ItemName"].Value.ToString();
            CmbUnit.Text = dgvItems.Rows[rowId].Cells["Unit"].Value.ToString();
            txtQty.Text = dgvItems.Rows[rowId].Cells["Qty"].Value.ToString();
            txtRate.Text = dgvItems.Rows[rowId].Cells["Rate"].Value.ToString();
            txtDiscPer.Text = dgvItems.Rows[rowId].Cells["DiscPer"].Value.ToString();
            txtDiscAmt.Text = dgvItems.Rows[rowId].Cells["DiscAmt"].Value.ToString();
            txtTaxableAMt.Text = dgvItems.Rows[rowId].Cells["TaxableAmt"].Value.ToString();
            cmbItemLevelTax.EditValue = dgvItems.Rows[rowId].Cells["TaxId"].Value;
            cmbItemLevelTax.Text = dgvItems.Rows[rowId].Cells["TaxName"].Value.ToString();
            txtIGSTPer.Text = dgvItems.Rows[rowId].Cells["IGSTPer"].Value.ToString();
            txtIGSTAmt.Text = dgvItems.Rows[rowId].Cells["IGSTAmt"].Value.ToString();
            txtCGSTPer.Text = dgvItems.Rows[rowId].Cells["CGSTPer"].Value.ToString();
            txtCGSTAmt.Text = dgvItems.Rows[rowId].Cells["CGSTAmt"].Value.ToString();
            txtSGSTPer.Text = dgvItems.Rows[rowId].Cells["SGSTPer"].Value.ToString();
            txtSGSTAmt.Text = dgvItems.Rows[rowId].Cells["SGSTAmt"].Value.ToString();
            txtItemAmount.Text = dgvItems.Rows[rowId].Cells["Amount"].Value.ToString();
            txtHSNCode.Text = dgvItems.Rows[rowId].Cells["HSNCode"].Value.ToString();
            txtitemdesc.Text = dgvItems.Rows[rowId].Cells["ItemDesc"].Value.ToString();
            dgvItems.Enabled = false;
        }

        private void txtT_FreightPer_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void txtT_FreightAmt_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();

        }

        private void txtT_PackingPer_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void txtT_PackingAmt_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void txtT_DiscountPer_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void txtT_DiscountAmt_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void FrmInvoiceMst_Shown(object sender, EventArgs e)
        {

        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are your sure want to delete item ?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index);
                    calNetAmt();
                }
            }
        }

        private void dtpInvDueDate_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void txtItemName_Validated(object sender, EventArgs e)
        {
            //if (txtItemName.Visible)
            //{
            //    if (txtItemName.Text.Length == 0)
            //    {
            //        if (MessageBox.Show("want to add more item ?", "Alert", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //        {
            //            txtItemName.Focus();
            //        }
            //        else
            //        {
            //            txtRemark.Focus();
            //        }
            //    }
            //}
        }

        private void cmbBook_Leave(object sender, EventArgs e)
        {
            GatMaxInvNo();

        }

        private void txtOth1AddPer_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void txtOth1AddAmt_EditValueChanged(object sender, EventArgs e)
        {
            calNetAmt();
        }

        private void slkp_ItemName_Validated(object sender, EventArgs e)
        {

        }
        void SetDueDate_Days()
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }

        private void txtCreditDays_Validated(object sender, EventArgs e)
        {
            dtpInvDueDate.EditValue = Convert.ToDateTime(dtpInvDate.EditValue).AddDays(Convert.ToInt32(txtCreditDays.Text));
        }

        private void dtpInvDueDate_Validated(object sender, EventArgs e)
        {
            DateTime linvdate = Convert.ToDateTime(dtpInvDate.EditValue);
            DateTime lduedate = Convert.ToDateTime(dtpInvDueDate.EditValue);

            txtCreditDays.Text = (lduedate - linvdate).TotalDays.ToString();
        }


    }
}