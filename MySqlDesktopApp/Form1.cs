using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------
using System.Data.SqlClient;

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
            ////This is makeing connections btween app and databasse.(making road app and database)
            ////SqlConnection con = new SqlConnection(Properties.Settings.Default.mysqlConn);
            ////This is Command for executing query (Vahical)
            //SqlCommand cmd; 
            //try
            //{  
                
      
        
            //    //this line open database connections means start the database connections.
               
            //    string query = "INSERT INTO `emp`(`name`, `email`, `address`) VALUES (@value2,@value3,@value4)";
            //    cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@value2",name.Text);
            //    cmd.Parameters.AddWithValue("@value3",email.Text);
            //    cmd.Parameters.AddWithValue("@value4",address.ToString());
            //    con.Open();
            //    int res = cmd.ExecuteNonQuery();
            //    MessageBox.Show("Your Database Inserted Successfully " + res);

            //}
            //catch (Exception msg)
            //{
            //    MessageBox.Show(msg.Message);
            //}
            //finally
            //{
            //    //this line close database connections for new query executions.
            //    con.Close();
            //}
        }

        //This method called when applcations loads
        private void Desktop_Load(object sender, EventArgs e)
        {
       

        }

     
    }
}
