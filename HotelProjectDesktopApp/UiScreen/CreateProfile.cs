using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//----
using HotelDashboard.WpfClient.Models;


namespace HotelDashboard.UiScreen
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
            this.setProfileTypes();
        }

        public void setProfileTypes(){
          List<ProfileTypes> result= new HotelDashboard.WpfClient.Operations.ProfileService().getProfileTypes();
          if (result.Any())
          {
              infoProfileTabel.Visible = true;
              this.setDataGridViewValues(result);
              result.ForEach(delegate(ProfileTypes profileType)
              {
                  profileTypeDrop.AddItem(profileType.type);
              });
          }
              
        }

        private void setDataGridViewValues(List<ProfileTypes> profileTypeList)
        {
            infoProfileTabel.DataSource = profileTypeList;
            infoProfileTabel.Columns["id"].Visible = false;
            infoProfileTabel.Columns["version"].Visible = false;
            infoProfileTabel.Columns["name"].Visible = false;
            // Resizing the name clounm
            infoProfileTabel.Columns["type"].HeaderText = "Profile Types";
            infoProfileTabel.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoProfileTabel.Columns["type"].Width = 100;
            // Changing header text featuers clounm
            infoProfileTabel.Columns["features"].HeaderText = "Profile Featuers";
            // Resizing the cost clounm
            infoProfileTabel.Columns["cost"].HeaderText = "Cost PerMonth";
            infoProfileTabel.Columns["cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoProfileTabel.Columns["cost"].Width = 80;
        }
    }
}
