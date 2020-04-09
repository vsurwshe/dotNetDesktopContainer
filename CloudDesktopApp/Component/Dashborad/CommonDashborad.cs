using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------
using CloudDesktopApp.Helper;


namespace CloudDesktopApp.Component.Dashborad
{
    public partial class CommonDashborad : Form
    {
        public CommonDashborad()
        {
            InitializeComponent();
        }

        private void CommonDashborad_Load(object sender, EventArgs e)
        {
            this.loadDashboradActivites();
        }

        public void loadDashboradActivites()
        {
            if (!GlobalClass.user.enabled)
            {
                notVerifyMessageBox.Visible = true;
                notVerifyMessageLable.Text = CommonMessage.NOT_ENABLED;
            }
        }
    }
}
