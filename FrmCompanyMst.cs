using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.Entity;
using System.IO;
namespace Inv
{
    public partial class FrmCompanyMst : Form
    {

        public int mPkValue = 0;
        public bool isCompanyModeNew = false;
        public FrmCompanyMst()
        {
            InitializeComponent();

        }
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
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
            LoadData();

        }
        void doSetControls()
        {
            //HelperClass.bCombBox_StateCode(cmbState);
            if (isCompanyModeNew)
                HelperClass.bCombBox_StateCodeXml(cmbState);
            else
                HelperClass.bCombBox_StateCode(cmbState);

            //DataSet ldts = new DataSet();            
            //ldts.Tables.Add(AppFun.EntityToDataTable(dbx.StateMsts.ToList()));
            //ldts.WriteXml(Application.StartupPath + @"\states.xml");

        }
        void LoadData()
        {
            if (isCompanyModeNew) return;
            var lqry = dbx.CompanyMsts.FirstOrDefault();
            if (lqry != null)
            {
                txtComapanyName.Text = lqry.CompanyName;
                txtAddress.Text = lqry.Address;
                cmbState.Text = lqry.State.ToString();
                txtStatecode.Text = lqry.StateCode;
                txtEmailid.Text = lqry.EmailId;
                txtContactNo.Text = lqry.ContactNo;
                txtGSTinNo.Text = lqry.TaxNo;
                txtPanNo.Text = lqry.PANNo;
                mPkValue = lqry.CompId;
                pBox_Logo.Image = byteArrayToImage(lqry.LogoImg);
            }
        }

        private void FrmCompanyMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null) return null;
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null) return null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtComapanyName.Text.Length == 0)
            {
                MessageBox.Show("Kindly enter company name.");
                txtComapanyName.Focus();
                return;
            }
            if (cmbState.Text.Length == 0)
            {
                MessageBox.Show("Kindly select state.");
                cmbState.Focus();
                return;
            }
            if (CreateNewCompanyConfiguration() == false) return;
            if (mPkValue == 0)
            {


                CompanyMst objcmp = new CompanyMst();
                objcmp.CompanyName = txtComapanyName.Text;
                objcmp.Address = txtAddress.Text;
                objcmp.State = cmbState.Text;
                objcmp.StateCode = txtStatecode.Text;
                objcmp.EmailId = txtEmailid.Text;
                objcmp.ContactNo = txtContactNo.Text;
                objcmp.TaxNo = txtGSTinNo.Text;
                objcmp.PANNo = txtPanNo.Text;
                objcmp.LogoImg = imageToByteArray(pBox_Logo.Image);

                dbx.CompanyMsts.Add(objcmp);
                dbx.SaveChanges();

                if (isCompanyModeNew)
                {
                    MessageBox.Show("New Company Created\n You need to restart a software..");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Company detail saved..");
                }

            }
            else
            {

                var objcmp = dbx.CompanyMsts.Where(u => u.CompId == mPkValue).First();
                if (objcmp != null)
                {
                    objcmp.CompanyName = txtComapanyName.Text;
                    objcmp.Address = txtAddress.Text;
                    objcmp.State = cmbState.Text;
                    objcmp.StateCode = txtStatecode.Text;
                    objcmp.EmailId = txtEmailid.Text;
                    objcmp.ContactNo = txtContactNo.Text;
                    objcmp.TaxNo = txtGSTinNo.Text;
                    objcmp.PANNo = txtPanNo.Text;
                    objcmp.LogoImg = imageToByteArray(pBox_Logo.Image);
                    dbx.SaveChanges();

                    DataSet ldtst = new DataSet();
                    ldtst.ReadXml(Application.StartupPath + @"\Conn.xml");
                    foreach (DataRow dr in ldtst.Tables[0].Select("dbname =" + AppInit.CompanyInfo.DbName))
                    {
                        dr["compname"] = txtComapanyName.Text;
                    }
                    ldtst.WriteXml(Application.StartupPath + @"\Conn.xml");
                    MessageBox.Show("Company detail updated..");
                }

            }
           
        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }

        private void cmbState_Leave(object sender, EventArgs e)
        {
            if (isCompanyModeNew)
            {
                DataSet ldts = new DataSet();
                ldts.ReadXml(Environment.CurrentDirectory + @"\states.xml");
                foreach (DataRow dr in ldts.Tables[0].Select("StateName='" + cmbState.Text.Trim() + "'"))
                {
                    txtStatecode.Text = dr["StateCode"].ToString().Trim();
                }
            }
            else
            {

                var lqry = dbx.StateMsts.Where(u => u.StateName == cmbState.Text.Trim()).FirstOrDefault();
                txtStatecode.Text = lqry.StateCode.Trim();
            }
        }

        private void btnImgBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            op.ShowDialog();
            if (op.FileName != null)
            {
                pBox_Logo.ImageLocation = op.FileName;
            }
        }

        bool CreateNewCompanyConfiguration()
        {
            if (mPkValue == 0)
            {
                DataSet ldtst = new DataSet(); int lnewcompid = 1;

                ldtst.ReadXml(Application.StartupPath + @"\Conn.xml");
                if (ldtst.Tables.Count > 0)
                {
                    lnewcompid = Convert.ToInt32(ldtst.Tables[0].Compute("max([compid])", string.Empty)) + 1;
                    ldtst.Tables[0].Rows.Add(lnewcompid, txtComapanyName.Text, lnewcompid);
                }
                else
                {
                    ldtst.Tables.Add("configruation");
                    ldtst.Tables[0].Columns.Add("compid", typeof(string));
                    ldtst.Tables[0].Columns.Add("compname", typeof(string));
                    ldtst.Tables[0].Columns.Add("dbname", typeof(string));
                    ldtst.Tables[0].Rows.Add(lnewcompid, txtComapanyName.Text, lnewcompid);
                }
                ldtst.WriteXml(Application.StartupPath + @"\Conn.xml");
                System.IO.File.Copy(Application.StartupPath + @"\cab\dump.sdf", Application.StartupPath + @"\cab\" + lnewcompid + ".sdf");
                AppFun.SetAppConnection(lnewcompid.ToString());

                //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                //string _connString = connectionStringsSection.ConnectionStrings["Inv_DatabaseEntities"].ConnectionString;
                //EntityConnectionStringBuilder ecsb = new EntityConnectionStringBuilder(_connString);                
                dbx = new Inv_DatabaseEntities(AppInit.AppInfo.EntityConnectionString);
                return true;
            }
            return true;
        }

    }
}