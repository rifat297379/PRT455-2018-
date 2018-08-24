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
    public partial class FrmCustomerList : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public FrmCustomerList()
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
            var lqry = dbx.CustomerMsts.ToList();

            xList.DataSource = lqry;
            xListDetail.Columns["CustomerId"].Visible = false;
            xListDetail.Columns["StateCode"].Visible = false;
            xListDetail.Columns["Country"].Visible = false;
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
                    int lpkvalue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("CustomerId"));
                    var lqryd = dbx.CustomerMsts.Where(u => u.CustomerId == lpkvalue).FirstOrDefault();

                    dbx.CustomerMsts.Remove(lqryd);
                   
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
            AppInit.FrmObjects.ObjFrmCustomerMst.mPkValue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("CustomerId"));
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
                if (Convert.ToInt32(xListDetail.GetFocusedRowCellValue("CustomerId")) > 0)
                {
                    btnSave_Click(sender, e);
                }
            }

        }
    }
}
