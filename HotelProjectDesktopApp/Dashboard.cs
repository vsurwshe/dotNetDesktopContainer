using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            //new HotelDashboard.UiScreen.UserDashboard().IsMdiContainer = true;
            Type typeOf = typeof(HotelDashboard.UiScreen.UserDashboard);
            createShowForm(typeOf);
            //  (Bunifu.Framework.UI.BunifuFlatButton) sender 
        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            Type typeOf = typeof(HotelDashboard.Helper.UserExceptions);
            createShowForm(typeOf);
        }

        //----------
        private void createShowForm(Type objectName)
        {
            try
            {
                HotelDashboard.Dashboard dash=new HotelDashboard.Dashboard();
                Object classObject = Activator.CreateInstance(objectName);

                if (classObject.GetType().GetProperty("MdiParent") != null)
                {
                    MessageBox.Show("" + classObject.GetType().GetProperty("MdiParent"));
                    // This line geting MidParent Porperties and Setting value of Current Dashboard by 2 parameter
                    classObject.GetType().GetProperty("MdiParent").SetValue(this,dash, null);
                    // This line geting Dock Porperties and Setting value of DockStyle.Fill by 2 parameter
                    classObject.GetType().GetProperty("Dock").SetValue(this, DockStyle.Fill, null);
                    
                }
                else
                    throw new Exception("Object Class Not Found");
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

      

    }
}


