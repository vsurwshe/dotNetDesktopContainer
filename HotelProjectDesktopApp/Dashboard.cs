using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            Type typeOf = typeof(HotelDashboard.UiScreen.UserDashboard);
            createShowForm(typeOf);
        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            Type typeOf = typeof(HotelDashboard.UiScreen.Customer);
            createShowForm(typeOf);
        }

        //----------
        private void createShowForm(Type objectName)
        {
            try
            {
               // This Line creating Object of What we passing Type of Object in parameters
                Object classObject = Activator.CreateInstance(objectName);
                if (classObject.GetType().GetProperty("MdiParent") != null)
                {
                    // This line geting MidParent Porperties and Setting value of Current Dashboard by 2 parameter
                    classObject.GetType().GetProperty("MdiParent").SetValue(classObject, this, null);
                    // This line geting Dock Porperties and Setting value of DockStyle.Fill by 2 parameter
                    classObject.GetType().GetProperty("Dock").SetValue(classObject, DockStyle.Fill, null);
                   // This line Find the Show mwthod and sloveing ambiguty form them. 
                    MethodInfo showMethod = classObject.GetType().GetMethods().Where(x => x.Name == "Show").Last(x => !x.ContainsGenericParameters);
                    // This method calling show method
                    showMethod.Invoke(classObject, null);
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


