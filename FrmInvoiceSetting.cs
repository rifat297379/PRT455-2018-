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
    public partial class FrmInvoiceSetting : Form
    {
        public FrmInvoiceSetting()
        {
            InitializeComponent();
        }
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();

        private void FrmInvoiceSetting_Load(object sender, EventArgs e)
        {
            txtInvoiceFormat.Text = AppInit.GetTextBoxApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_invoiceformate.ToString());
            txtChallanFormat.Text = AppInit.GetTextBoxApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_challanformat.ToString());
            cmbCopy.Text = AppInit.GetTextBoxApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_DefaultCopyTag.ToString());

            chkInvoiceTaxOnTotalLevel.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_invoiceTaxonTotalLevel.ToString());
            chkItemHelp.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_invoiceItemHelp.ToString());
            chkShippingDetails.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_EnableShippingDetail.ToString());
            chlOtherAddField.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_EnableOth1Add.ToString());
            chkPrintChallanEnable.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_EnablePrintChallan.ToString());


            chk_bf_freight.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_Enable_bf_freight.ToString());
            chk_bf_additional.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_Enable_bf_additional.ToString());
            chk_bf_discount.Checked = AppInit.GetCheckBoxOrRaddioApplicationSettings(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_Enable_bf_discount.ToString());

            var lqry = dbx.BookMsts.ToList();
            foreach (var item in lqry)
            {

                int rowId = gvBook.Rows.Add();
                gvBook.Rows[rowId].Cells["BookId"].Value = item.BookId;
                gvBook.Rows[rowId].Cells["BookName"].Value = item.BookName;
                gvBook.Rows[rowId].Cells["BookTitle"].Value = item.BookTitle;
                gvBook.Rows[rowId].Cells["InvNo"].Value = item.InvNo;
                gvBook.Rows[rowId].Cells["Prefix"].Value = item.Prefix;

                gvBook.Rows[rowId].Cells["IsActive"].Value = item.IsActive;
                gvBook.Rows[rowId].Cells["IsDefault"].Value = item.IsDefault;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_invoiceTaxonTotalLevel.ToString(), chkInvoiceTaxOnTotalLevel.Checked ? "1" : "0");
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_invoiceItemHelp.ToString(), chkItemHelp.Checked ? "1" : "0");
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_EnableShippingDetail.ToString(), chkShippingDetails.Checked ? "1" : "0");
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_EnablePrintChallan.ToString(), chkPrintChallanEnable.Checked ? "1" : "0");

            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_Enable_bf_freight.ToString(), chk_bf_freight.Checked ? "1" : "0");
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_Enable_bf_additional.ToString(), chk_bf_additional.Checked ? "1" : "0");
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_Enable_bf_discount.ToString(), chk_bf_discount.Checked ? "1" : "0");



            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_invoiceformate.ToString(), txtInvoiceFormat.Text);
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_challanformat.ToString(), txtChallanFormat.Text);
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_DefaultCopyTag.ToString(), cmbCopy.Text);
            AppInit.UpdateSoftwareSetting(AppInit.SoftwareSettings.SoftwareSettingCode.Inv_EnableOth1Add.ToString(), chlOtherAddField.Checked ? "1" : "0");
            AppInit.SoftwareSettings.IntiSetting();

            for (int i = 0; i < gvBook.Rows.Count; i++)
            {
                int lbookid = Convert.ToInt32(gvBook.Rows[i].Cells["BookId"].Value);
                var objitm = dbx.BookMsts.Where(u => u.BookId == lbookid).First();
                if (objitm != null)
                {
                    objitm.BookTitle = gvBook.Rows[i].Cells["BookTitle"].Value.ToString();
                    objitm.InvNo = Convert.ToInt32(gvBook.Rows[i].Cells["InvNo"].Value);
                    objitm.IsActive = Convert.ToBoolean(gvBook.Rows[i].Cells["IsActive"].Value);
                    objitm.IsDefault = Convert.ToBoolean(gvBook.Rows[i].Cells["IsDefault"].Value);
                    objitm.Prefix = Convert.ToString(gvBook.Rows[i].Cells["Prefix"].Value);
                    dbx.SaveChanges();
                   
                }
            }

            MessageBox.Show("Software Setting updated..");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInvoiceSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
