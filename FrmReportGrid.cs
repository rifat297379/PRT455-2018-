using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.LookAndFeel;
using System.Drawing.Printing;
namespace Inv
{
    public partial class FrmReportGrid : Form
    {
        public int mReportId = 0;
        string mQry = string.Empty;
        string mReportTitle = string.Empty;
        string mReportParameter = string.Empty;
        string mTempPath = Application.StartupPath + @"\Temp";
        PrintableComponentLink mlink = new PrintableComponentLink();
        public FrmReportGrid()
        {
            InitializeComponent();
        }

        private void FrmReportGrid_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(mTempPath))
            {
                Directory.CreateDirectory(mTempPath);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //xList.ShowPrintPreview();
            mlink = new PrintableComponentLink()
            {
                PrintingSystemBase = new PrintingSystemBase(),
                Component = xList,
                Landscape = true,
                PaperKind = PaperKind.A4,
                Margins = new Margins(20,20,50,20),                
            };
            mlink.CreateMarginalHeaderArea += link_CreateMarginalHeaderArea;
            mlink.ShowPreviewDialog();
        }       

        void link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {            
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Near);
            e.Graph.Font = new Font("Tahoma", 11, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(mReportTitle, Color.Black, rec, BorderSide.None);
        }
        
        private void btnExportXls_Click(object sender, EventArgs e)
        {
            string FileName = mTempPath + @"\" + GenRendom() + ".xls";
            //mlink = new PrintableComponentLink()
            //{
            //    PrintingSystemBase = new PrintingSystemBase(),
            //    Component = xList,
            //    Landscape = true,
            //    PaperKind = PaperKind.A4,
            //    Margins = new Margins(20, 20, 50, 20),
            //};
            //mlink.CreateMarginalHeaderArea += link_CreateMarginalHeaderArea;
            //mlink.ExportToXls(FileName);

            xList.ExportToXls(FileName);
            System.Diagnostics.Process.Start(FileName);
        }
        string GenRendom()
        {
            Random generator = new Random();
            string r = generator.Next(0, 1000000).ToString("D6");
            return r;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            string FileName = mTempPath + @"\" + GenRendom() +".pdf";
            mlink = new PrintableComponentLink()
            {
                PrintingSystemBase = new PrintingSystemBase(),
                Component = xList,
                Landscape = true,
                PaperKind = PaperKind.A4,
                Margins = new Margins(20, 20, 50, 20),
            };
            mlink.CreateMarginalHeaderArea += link_CreateMarginalHeaderArea;
            mlink.ExportToPdf(FileName);

            //xList.ExportToPdf(FileName);
            System.Diagnostics.Process.Start(FileName);
        }

        private void FrmReportGrid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmReportGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();

        }

        private void FrmReportGrid_Shown(object sender, EventArgs e)
        {
            if (mReportId == 0) return;
            DataTable ldts = DbFun.ExecDtblRtrn(ReturnQueryString(mReportId));
            xList.DataSource = ldts;

            xListDetail.BestFitColumns();
            foreach (DataColumn dcols in ldts.Columns)
            {
                string dttype = dcols.DataType.ToString();
                if (dttype == "System.Int32" | dttype == "System.Decimal" | dttype == "System.Double" | dttype == "System.Int16" | dttype == "System.Int64")
                {
                    xListDetail.Columns[dcols.ColumnName].Summary.Add(DevExpress.Data.SummaryItemType.Sum, dcols.ColumnName);
                    //xListDetail.Columns[ (dcols.ColumnName).Summary.Add(DevExpress.Data.SummaryItemType.Sum, dcols.ColumnName);
                    GridGroupSummaryItem item1 = new GridGroupSummaryItem();
                    item1.FieldName = dcols.ColumnName;
                    item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    //item1.DisplayFormat = "Total {0:c2}"
                    item1.ShowInGroupColumnFooter = xListDetail.Columns[dcols.ColumnName];
                    xListDetail.GroupSummary.Add(item1);
                }

            }

            this.Text = "Report > " + mReportTitle;

            if (System.IO.File.Exists(Application.StartupPath + @"\Layout\" + mReportTitle))
            {
                xList.ForceInitialize();
                xList.MainView.RestoreLayoutFromXml(Application.StartupPath + @"\Layout\" + mReportTitle);
            }
            //PreviewPrintableComponent(xList,xList.LookAndFeel);
        }
        void SummaryTotalSet()
        {

        }
        string ReturnQueryString(int _reportid)
        {
            string qry = "";
            qry = "Select * from MISReport Where ReportId =" + _reportid;
            DataTable ltbl = DbFun.ExecDtblRtrn(qry);
            foreach (DataRow dr in ltbl.Rows)
            {
                mQry = dr["Qry"].ToString();
                mReportTitle = dr["ReportTitle"].ToString();
                return mQry;
            }

            return "";
        }

        private void btnSaveFormat_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(Application.StartupPath +@"\Layout"))
            {
                Directory.CreateDirectory(Application.StartupPath +@"\Layout");
            }
            xList.MainView.SaveLayoutToXml(Application.StartupPath + @"\Layout\" + mReportTitle);
        }
    }
}
