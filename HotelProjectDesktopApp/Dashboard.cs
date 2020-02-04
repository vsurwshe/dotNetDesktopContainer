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
            this.DashboradButton_Click(sender, e);  
        }

        private void DashboradButton_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfUserDashboard = typeof(HotelDashboard.UiScreen.UserDashboard);
                this.createShowForm(typeOfUserDashboard);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

        private void CustmerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfCustomer = typeof(HotelDashboard.UiScreen.Customer);
                this.createShowForm(typeOfCustomer);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

        private void FoodsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfFoods = typeof(HotelDashboard.UiScreen.Foods);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfProfile = typeof(HotelDashboard.UiScreen.Profile);
                this.createShowForm(typeOfProfile);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfHelp = typeof(HotelDashboard.UiScreen.Help);
                this.createShowForm(typeOfHelp);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            try
            {   // This line called the UserService exit method
                new HotelDashboard.Helper.UserService().appExit();
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }
       
        //----------
        private void createShowForm(Type objectName)
        {
            try
            {
               // This Line creating Object of What we passing Type of Object in parameters
                Object classObject = Activator.CreateInstance(objectName);
                if (classObject.GetType().GetProperty("MdiParent") != null)
                {   // This line geting MidParent Porperties and Setting value of Current Dashboard by 2 parameter
                    classObject.GetType().GetProperty("MdiParent").SetValue(classObject, this, null);
                    // This line geting Dock Porperties and Setting value of DockStyle.Fill by 2 parameter
                    classObject.GetType().GetProperty("Dock").SetValue(classObject, DockStyle.Fill, null);
                   // This line Find the Show mwthod and sloveing ambiguty form them. 
                    MethodInfo showMethod = classObject.GetType().GetMethods().Where(x => x.Name == "Show").Last(x => !x.ContainsGenericParameters);
                    // This method calling show method
                    showMethod.Invoke(classObject, null);
                }
                else
                    throw new Exception(objectName +" Class Not Found Exception.");
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }
    }
}


