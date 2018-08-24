using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Inv
{
    public partial class SplashScreen : DevExpress.XtraSplashScreen.SplashScreen
    {
        Inv_DatabaseEntities dbx = new Inv_DatabaseEntities();
        public SplashScreen()
        {
            InitializeComponent();
            dbx.CompanyMsts.Find(0);
            
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            
           

        }
    }
}