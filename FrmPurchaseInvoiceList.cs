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
    public partial class FrmPurchaseInvoiceList : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public int mInvId = 0;
        public FrmPurchaseInvoiceList()
        {
            InitializeComponent();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            
            
        }

        private void FrmCustomerList_Shown(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void FillGrid()
        {
            var lqry = (from i in dbx.PurInvoiceMsts
                        join c in dbx.SupplierMsts on i.SupplierId equals c.SupplierId
                        select new
                        {
                            i.InvId,
                            i.InvoiceType,
                            i.InvoiceNo,
                            i.InvoiceDate,
                            c.SupplierName,
                            i.NetAmt,
                            i.GSTType,
                            i.Status
                        }).OrderByDescending(d=> d.InvId).ToList();

            xList.DataSource = lqry;
            xListDetail.Columns["InvId"].Visible = false;
            if (lqry.Count == 0)
            {
                btnSave.Enabled = false;
                btnList.Enabled = false;
                
            }
        }
        private void FrmCustomerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are your sure want to delete ?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int lpkvalue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("InvId"));
                    var lqry = dbx.PurInvoiceMsts.Where(u => u.InvId == lpkvalue).FirstOrDefault();
                    dbx.PurInvoiceMsts.Remove(lqry);
                    var lqryds = dbx.PurInvoiceDets.Where(u => u.InvId == lpkvalue).ToList();
                    foreach (var item in lqryds)
                    {
                        dbx.PurInvoiceDets.Remove(item);
                    }
                    dbx.SaveChanges();
                    FillGrid();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmPurchseInvoice.mPkValue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("InvId"));
            AppInit.FrmObjects.ObjFrmPurchseInvoice.mbDataLoaded = false;
            this.Close();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void xListDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(xListDetail.GetFocusedRowCellValue("InvId")) > 0)
                {
                    btnSave_Click(sender, e);
                }
            }

        }


    }
}
