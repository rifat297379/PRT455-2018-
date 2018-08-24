using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
namespace Inv
{
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test1");
            //MessageBox.Show(LicenseChecker.GetActivationCode());
            FrmCompanySelection objcmp = new FrmCompanySelection();
            objcmp.ShowDialog();
            //MessageBox.Show("Test2");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                AppInit.UserInfo.UserId = 1;
                AppInit.UserInfo.isSuperAdmin = true;
            }
            if (AppInit.UserInfo.UserId == 0)
            {
                FrmLogin objlogin = new FrmLogin();
                objlogin.ShowDialog();
            }
            FrmLogin.GetCompanyInfo();
            this.Text = AppInit.CompanyInfo.CompanyName;
            DbFun.OpenConn();
            // super admin permission
            if (AppInit.UserInfo.isSuperAdmin)
            {
                reportDesignToolStripMenuItem.Visible = true;
                dashDesignerToolStripMenuItem.Visible = true;
            }


            AppInit.SoftwareSettings.IntiSetting();

            if (System.IO.Directory.Exists(Application.StartupPath + @"\Temp"))
            {
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(Application.StartupPath + @"\Temp");
                foreach (System.IO.FileInfo file in directory.GetFiles()) file.Delete();

            }


            ////------------ Dashboard 
            //DevExpress.DashboardCommon.Dashboard dbs = new DevExpress.DashboardCommon.Dashboard();
            //dbs.ConfigureDataConnection += dbs_ConfigureDataConnection;
            //dbs.LoadFromXml(Application.StartupPath + @"\Dash\D1.xml");
            //db_view_Dash.Dashboard = dbs;

            //InitDashbaord();

        }

        void dbs_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            if (e.DataSourceName == "MainSource")
            {
                MsSqlCEConnectionParameters ceconn = (MsSqlCEConnectionParameters)e.ConnectionParameters;
                //string lcurrentconn = ceconn.FileName;
                ceconn.FileName = Application.StartupPath + @"\cab\" + AppInit.CompanyInfo.DbName + ".sdf";

                //int lstartidx = lcurrentconn.IndexOf(@"\cab\");
                //int lendidx = lcurrentconn.LastIndexOf(".sdf")-1;
                //string ldbname = lcurrentconn.Substring(lstartidx + 5, lcurrentconn.Length - lendidx);

                //if (lcurrentconn.Contains(ldbname))
                //{
                //    lcurrentconn = lcurrentconn.Replace(ldbname, AppInit.CompanyInfo.DbName == null ? ldbname + ".sdf" : AppInit.CompanyInfo.DbName + ".sdf");
                //    ceconn.FileName = lcurrentconn;
                //}

            }
        }


        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmCustomerMst = new FrmCustomerMst();
            AppInit.FrmObjects.ObjFrmCustomerMst.ShowDialog();

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmItemMst = new FrmItemMst();
            AppInit.FrmObjects.ObjFrmItemMst.ShowDialog();
        }

        private void taxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmTaxMst = new FrmTaxMst();
            AppInit.FrmObjects.ObjFrmTaxMst.ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmInvoiceMst = new FrmInvoiceMst();
            AppInit.FrmObjects.ObjFrmInvoiceMst.ShowDialog();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmReceiptEntry = new FrmReceiptEntry();
            AppInit.FrmObjects.ObjFrmReceiptEntry.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportGrid objrepgrid = new FrmReportGrid();
            objrepgrid.mReportId = 1;
            objrepgrid.Show();
        }

        private void comapanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompanyMst objfrmcompmst = new FrmCompanyMst();
            objfrmcompmst.ShowDialog();
            this.Text = AppInit.CompanyInfo.CompanyName;
        }

        private void invoiceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoiceSetting objsett = new FrmInvoiceSetting();
            objsett.ShowDialog();
        }

        private void receiptSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receiptToolStripMenuItem_Click(sender, e);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword objchangepwd = new FrmChangePassword();
            objchangepwd.ShowDialog();
        }

        private void Sub_Master_Customer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            customersToolStripMenuItem_Click(sender, e);
        }

        private void Sub_Master_Item_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            itemsToolStripMenuItem_Click(sender, e);
        }

        private void Sub_Master_Taxes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            taxesToolStripMenuItem_Click(sender, e);
        }

        private void Sub_Tran_Invoice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            invoiceToolStripMenuItem_Click(sender, e);
        }

        private void Sub_Tran_Receipt_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            receiptSettingToolStripMenuItem_Click(sender, e);
        }

        private void Sub_Setting_Company_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            comapanyToolStripMenuItem_Click(sender, e);
        }

        private void reportDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportDesigner objrepord = new FrmReportDesigner();
            objrepord.Show();
        }

        private void Sub_Setting_Invoice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            invoiceSettingToolStripMenuItem_Click(sender, e);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup objbkp = new FrmBackup();
            objbkp.isPormteMode = false;
            objbkp.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppInit.AppInfo.AskBackupWhenCloseSoftware)
            {
                FrmBackup objbkp = new FrmBackup();
                objbkp.isPormteMode = true;
                if (objbkp.ShowDialog() == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void saleRegisterDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportGrid objrepgrid = new FrmReportGrid();
            objrepgrid.mReportId = 2;
            objrepgrid.Show();
        }

        private void dashDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmDashDesigner objdash = new Forms.frmDashDesigner();
            objdash.ShowDialog();
        }

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmPurchseInvoice = new FrmPurchseInvoice();
            AppInit.FrmObjects.ObjFrmPurchseInvoice.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmInvoiceMst = new FrmInvoiceMst();
            AppInit.FrmObjects.ObjFrmInvoiceMst.ShowDialog();
        }

        private void receiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmReceiptEntry = new FrmReceiptEntry();
            AppInit.FrmObjects.ObjFrmReceiptEntry.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmSupplierMst = new FrmSupplierMst();
            AppInit.FrmObjects.ObjFrmSupplierMst.ShowDialog();
        }

        private void Sub_Tran_PurchaseInvoice_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            purchaseInvoiceToolStripMenuItem_Click(sender, e);
        }

        private void Sub_Master_Supplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            suppliersToolStripMenuItem_Click(sender, e);
        }

        private void saleRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportGrid objrepgrid = new FrmReportGrid();
            objrepgrid.mReportId = 1;
            objrepgrid.Show();
        }

        private void saleRegisterDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportGrid objrepgrid = new FrmReportGrid();
            objrepgrid.mReportId = 2;
            objrepgrid.Show();
        }

        private void saleOutstandingToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void receiptRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Sub_Report_SaleRegister_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            saleRegisterToolStripMenuItem1_Click(sender, e);
        }

        private void Sub_Report_SaleRegisterDet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            saleRegisterDetailsToolStripMenuItem_Click(sender, e);
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            //if (tabPane1.SelectedPageIndex == 0)
            //{
            //    Dash.Refresh_Call_dashboard(tabPane1.SelectedPage.Name.ToString(), TabDashInner.SelectedPage.Name.ToString());
            //}
            //else
            //{
            //    Dash.Refresh_Call_dashboard(tabPane1.SelectedPage.Name.ToString(), tabChartInner.SelectedPage.Name.ToString());
            //}
            Dash.Refresh_Call_dashboard(tabPane1.SelectedPage.Name.ToString(), tabChartInner.SelectedPage.Name.ToString());
        }

        private void TabDashInner_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            Dash.Refresh_Call_dashboard(tabPane1.SelectedPage.Name.ToString(), TabDashInner.SelectedPage.Name.ToString());
        }

        private void tabChartInner_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            Dash.Refresh_Call_dashboard(tabPane1.SelectedPage.Name.ToString(), tabChartInner.SelectedPage.Name.ToString());
        }


        void InitDashbaord()
        {
            AppInit.FrmObjects.ObjFrmDashSale.TopLevel = false;
            tabPageDash_Sale.Controls.Add(AppInit.FrmObjects.ObjFrmDashSale);
            AppInit.FrmObjects.ObjFrmDashSale.Show();
        }

        private void serviceInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmServiceInvoice = new FrmServiceInvoice();
            AppInit.FrmObjects.ObjFrmServiceInvoice.ShowDialog();
        }

    }
}
