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
    public partial class FrmCompanySelection : Form
    {
        public FrmCompanySelection()
        {
            InitializeComponent();
        }

        private void FrmCompanySelection_Load(object sender, EventArgs e)
        {
            FillCompList();
        }
        void FillCompList()
        {
            try
            {
                DataSet dtst = new DataSet();
                //MessageBox.Show("C1");
                dtst.ReadXml(Application.StartupPath + @"\Conn.xml");
                xGridCompany.DataSource = dtst.Tables[0];
                gridCompany.Columns["compid"].Visible = false;
                gridCompany.Columns["dbname"].Visible = false;
                gridCompany.Columns["compname"].Caption = "Company Name";
                gridCompany.FindFilterText = "";
                gridCompany.OptionsBehavior.ReadOnly = true;
                gridCompany.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                gridCompany.FocusedColumn = gridCompany.Columns["compname"];

            }
            catch (Exception)
            {

                
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            CompanySelectionDo();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
         
            //AppFun.SetAppConnection("dump");
            FrmCompanyMst objfrmcompmst = new FrmCompanyMst();
            objfrmcompmst.isCompanyModeNew = true;
            objfrmcompmst.ShowDialog();            
            FillCompList();
        }

        private void xGridCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CompanySelectionDo();
            }
        }

        void CompanySelectionDo()
        {

            string ldbname = string.Empty;
            string lcompid = string.Empty;
            if (gridCompany.SelectedRowsCount == 0 && gridCompany.FocusedRowHandle < 0) return;
            if (gridCompany.SelectedRowsCount == 0)
            {
                gridCompany.FocusedRowHandle = 0;
                lcompid = gridCompany.GetFocusedRowCellValue("compid").ToString();
            }
            else if (gridCompany.FocusedRowHandle < 0)
            {
                gridCompany.FocusedRowHandle = 0;
                lcompid = gridCompany.GetFocusedRowCellValue("compid").ToString();
            }
            else
            { lcompid = gridCompany.GetFocusedRowCellValue("compid").ToString(); }
            if (lcompid.Length > 0)
            {
                DataTable ltb = (DataTable)xGridCompany.DataSource;
                foreach (DataRow dr in ltb.Select(" compid = '" + lcompid + "'"))
                {
                    AppInit.CompanyInfo.CompanyName = dr["compname"].ToString();
                    AppInit.CompanyInfo.DbName = dr["dbname"].ToString();

                }
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                AppInit.CompanyInfo.DbName = "";
            }

            if (AppInit.CompanyInfo.DbName.Length != 0)
            {
                //var config = new ConfigurationSettings.ap

                AppFun.SetAppConnection(AppInit.CompanyInfo.DbName);

            }

        }
    }
}
