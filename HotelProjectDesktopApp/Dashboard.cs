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
//-----
using HotelDashboard.UiScreen;
using HotelDashboard.UiScreen.Customer;
using HotelDashboard.UiScreen.Foods;
using HotelDashboard.UiScreen.Profile;


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
                Type typeOfUserDashboard = typeof(UserDashboard);
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
                Type typeOfCustomer = typeof(Customer);
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
                Type typeOfFoods = typeof(Foods);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }

        public void ProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfProfile = typeof(Profile);
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
                Type typeOfHelp = typeof(HotelDashboard.UiScreen.Help.Help);
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
        public ContextMenuStrip menu = new ContextMenuStrip();
        private void leftSideMenu_Click(object sender, EventArgs e)
        {
            menu.Items.Clear();
            menu.Items.Add("Profile Management");
            menu.Items.Add("User Setting");
            menu.Items.Add("User Help Menu");
            menu.Items.Add("User Sign Out");
            menu.ItemClicked += this.menu_ItemClicked;
            menu.Show(leftSideMenu, new Point(0, leftSideMenu.Height));
        }

        private void menu_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
        { 
            switch(e.ClickedItem.Text){
                case "Profile Management":
                    this.ProfileButton_Click(sender, e);
                    e.ClickedItem.Text = "";
                    break;
                case "User Setting":
                    this.ProfileButton_Click(sender, e);
                    e.ClickedItem.Text = "";
                    break;
                case "User Help Menu":
                    this.HelpButton_Click(sender, e);
                    e.ClickedItem.Text = "";
                    break;
                case "User Sign Out":
                    this.SignOut_Click(sender, e);
                    e.ClickedItem.Text = "";
                    break;
            }
        }
    }
}


