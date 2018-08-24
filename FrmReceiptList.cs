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
    public partial class FrmReceiptList : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public int mInvId = 0;
        public FrmReceiptList()
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
            var lqry = (from i in dbx.InvoiceMsts
                        join c in dbx.CustomerMsts on i.CustomerId equals c.CustomerId
                        select new
                        {
                            i.InvId,
                            i.InvoiceType,
                            i.InvoiceNo,
                            i.InvoiceDate,
                            c.CustomerName,
                            i.NetAmt,
                            i.GSTType,
                            i.Status
                        }).ToList();

            xList.DataSource = lqry;
            xListDetail.Columns["InvId"].Visible = false;
            if (lqry.Count == 0)
            {
                btnSave.Enabled = false;
                btnList.Enabled = false;
                btnPrint.Enabled = false;
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
                    var lqry = dbx.InvoiceMsts.Where(u => u.InvId == lpkvalue).FirstOrDefault();
                    dbx.InvoiceMsts.Remove(lqry);
                    var lqryds = dbx.InvoiceDets.Where(u => u.InvId == lpkvalue).ToList();
                    foreach (var item in lqryds)
                    {
                        dbx.InvoiceDets.Remove(item);
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
            AppInit.FrmObjects.ObjFrmInvoiceMst.mPkValue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("InvId"));
            AppInit.FrmObjects.ObjFrmInvoiceMst.mbDataLoaded = false;
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

        public void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ldts = new DataSet();
                Int32 lInvId = 0;
                if (mInvId > 0)
                {
                    lInvId = mInvId;
                }
                else
                {
                    lInvId = Convert.ToInt16(xListDetail.GetRowCellValue(xListDetail.FocusedRowHandle, "InvId").ToString());
                }
                Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
                var querymst = from c in dbx.InvoiceMsts where c.InvId == lInvId select c;
                var querydet = from c in dbx.InvoiceDets where c.InvId == lInvId select c;
                var querycustomer = from c in dbx.CustomerMsts where c.CustomerId == querymst.FirstOrDefault().CustomerId select c;
                var querycompany = from c in dbx.CompanyMsts select c;
                var queryitm = from c in dbx.ItemMsts select c;


                ldts.Tables.Add(AppFun.EntityToDataTable(querycustomer.ToList()));
                ldts.Tables.Add(AppFun.EntityToDataTable(querydet.ToList()));
                ldts.Tables.Add(AppFun.EntityToDataTable(querymst.ToList()));

                int netamt = Convert.ToInt32(querymst.FirstOrDefault().NetAmt);
                string InrRup = AppFun.NumberToWords(netamt);



                ldts.DataSetName = "Source1";
                ldts.Tables[0].TableName = "CustomerMst";
                ldts.Tables[1].TableName = "InvoiceDet";
                ldts.Tables[2].TableName = "InvoiceMst";
                
                
                DevExpress.XtraReports.UI.XtraReport report = DevExpress.XtraReports.UI.XtraReport.FromFile(Environment.CurrentDirectory+ @"\Reports\" + AppInit.SoftwareSettings.Inv_invoiceformateValue,true);
                //DevExpress.XtraReports.UI.XtraReport report =new DevExpress.XtraReports.UI.XtraReport();
                //report.LoadLayout(Environment.CurrentDirectory + @"\Reports\" + AppInit.SoftwareSettings.Inv_invoiceformateValue);
                
                DevExpress.XtraReports.UI.ReportPrintTool tool = new DevExpress.XtraReports.UI.ReportPrintTool(report);
                report.RequestParameters = false;
                report.Parameters["Inr"].Value = InrRup;
                report.Parameters["Inr"].Visible = false;
                //report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Name = "Inr", Type = typeof(string), Value = InrRup, Description = "Inr" });
                report.DataSource = ldts;
                report.DataMember = ldts.Tables[1].TableName;                
                tool.ShowPreviewDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }

        }
    }
}
