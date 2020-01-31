using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//----------------
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlDesktopApp
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // This line calling insert method emp table adapter and save result return no of records save 
                int res = this.empTableAdapter.Insert(name.Text, email.Text, address.Text);
                if (res > 0)
                {
                    // This  line calling user service class method for successfull show message
                    new UserService().showSuccessMessage("Your Database Inserted Successfully " + res);
                    // This line after sucessfully inserted reloading the datagrid view  
                    this.Desktop_Load(sender,e);
                }
                else
                {
                    // This  line calling user service class method for show error message
                    new UserService().showErrorMessage("Sorry Your Data is not Inserted SuccessFully");
                }
               
            }
            catch (Exception msg)
            {
                // This  line calling user service  exptions class method for showing excption message
                new UserExpectionService().showExceptions(msg.Message);
            }
            
        }

        // This method called when applcations loads
        private void Desktop_Load(object sender, EventArgs e)
        {   try
            {
                // This line of code loads data into the 'vishva_Ds.emp' table. You can move, or remove it, as needed.
                this.empTableAdapter.Fill(this.vishva_Ds.emp);
            }
            catch (Exception msg)
            {
                // This  line calling user service  exptions class method for showing excption message
                new UserExpectionService().showExceptions(msg.Message);
            }
       
        }

        private void empBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.empBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.vishva_Ds);
            }
            catch (Exception msg)
            {
               // This  line calling user service  exptions class method for showing excption message
               new UserExpectionService().showExceptions(msg.Message);
            }

        }

     
    }
}
