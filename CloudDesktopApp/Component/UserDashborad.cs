using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.Component.Profile;
using CloudDesktopApp.Component.Dashborad;
using CloudDesktopApp.Component.Customer;
using CloudDesktopApp.Component.HotelTabel;
using CloudDesktopApp.Component.Setting;
using CloudDesktopApp.Component.Help;
using CloudDesktopApp.Component.MainTable;
using CloudDesktopApp.ApiOperations;
using System.Reflection;

namespace CloudDesktopApp.Component
{
    public partial class UserDashborad : Form
    {
        public UserDashborad()
        {
            InitializeComponent();
        }

        MaterialContextMenuStrip materialContextStrip = new MaterialContextMenuStrip();
        private void leftSideMenu_Click(object sender, EventArgs e)
        {
            materialContextStrip.Items.Clear();
            materialContextStrip.Items.Add("Profile Management");
            materialContextStrip.Items.Add("User Setting");
            materialContextStrip.Items.Add("User Help Menu");
            materialContextStrip.Items.Add("User Sign Out");
            materialContextStrip.ItemClicked += this.materialContextStrip_ItemClicked;
            materialContextStrip.Show(leftSideMenu, new Point(0, leftSideMenu.Height));
        }

        private void UserDashborad_Load(object sender, EventArgs e)
        {
            this.Dashboard_Click(sender, e);
            try
            {
                String profileId = Properties.Settings.Default.profileId;
                if (profileId.Equals(""))
                {
                    List<ProfileModel> profiles = new ProfileApiService().loadProfiles();
                    if (profiles != null)
                    {
                        Properties.Settings.Default.profileId = profiles.First().profileId.ToString();
                    }
                    else
                    {
                        UserMessage.showSuccessMessage(CommonMessage.PROFILE_CREATED_MESSAGE);
                    }
                }
                new ProfileManagement().loadProfiles();
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void Dashboard_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfFoods = typeof(CommonDashborad);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void Food_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfFoods = typeof(FoodManagement);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void Tabel_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfFoods = typeof(Tabel);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void signOut()
        {
            try
            {
                CommonClasses.appExit();
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void settingLoad()
        {
            try
            {
                Type typeOfFoods = typeof(UserSetting);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void helpLoad()
        {
            try
            {
                Type typeOfFoods = typeof(HelpForm);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void profileLoad()
        {
            try
            {
                Type typeOfFoods = typeof(ProfileManagement);
                this.createShowForm(typeOfFoods);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void dailyTabelTrans_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfMainTabel = typeof(MainTableManagement);
                this.createShowForm(typeOfMainTabel);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void customer_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeOfCustomer = typeof(CustomerManagment);
                this.createShowForm(typeOfCustomer);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void DashboradIconButton_Click(object sender, EventArgs e)
        {
            this.Dashboard_Click(sender, e);
        }

        private void FoodsIconButton_Click(object sender, EventArgs e)
        {
            this.Food_Click(sender,e);
        }

        private void TabelIconButton_Click(object sender, EventArgs e)
        {
            this.Tabel_Click(sender, e);
        }

       
        private void logout_Click(object sender, EventArgs e)
        {
            this.signOut();
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            this.profileLoad();
        }

        private void settingIconButton_Click(object sender, EventArgs e)
        {
            this.settingLoad();
        }

        private void helpIconButton_Click(object sender, EventArgs e)
        {
            this.helpLoad();
        }

        //--------------  Private Method implemente
        private void materialContextStrip_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Profile Management":
                    this.profileLoad();
                    e.ClickedItem.Text = "";
                    break;
                case "User Setting":
                    this.settingLoad();
                    e.ClickedItem.Text = "";
                    break;
                case "User Help Menu":
                    this.helpLoad();
                    e.ClickedItem.Text = "";
                    break;
                case "User Sign Out":
                    this.signOut();
                    e.ClickedItem.Text = "";
                    break;
            }
        }

        public void createShowForm(Type objectName)
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
                    throw new Exception(objectName + " Class Not Found Exception.");
            }
            catch (Exception msg)
            {
                CloudDesktopApp.Helper.UserMessage.ShowExceptions(msg.Message);
            }
        }
    }
}
