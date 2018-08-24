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
    public partial class FrmTaxList : Form
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public FrmTaxList()
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
            var lqry = dbx.TaxMsts.ToList();

            xList.DataSource = lqry;
            xListDetail.Columns["TaxId"].Visible = false;
            xListDetail.Columns["IsActive"].Visible = false;        
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
                    int lpkvalue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("TaxId"));
                    if (lpkvalue > 0)
                    {
                        var lqryd = dbx.TaxMsts.Where(u => u.TaxId == lpkvalue).FirstOrDefault();

                        dbx.TaxMsts.Remove(lqryd);

                        dbx.SaveChanges();
                        FillGrid();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppInit.FrmObjects.ObjFrmTaxMst.mPkValue = Convert.ToInt32(xListDetail.GetFocusedRowCellValue("TaxId"));
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
                if (Convert.ToInt32(xListDetail.GetFocusedRowCellValue("TaxId")) > 0)
                {
                    btnSave_Click(sender, e);
                }
            }

        }
    }
}
