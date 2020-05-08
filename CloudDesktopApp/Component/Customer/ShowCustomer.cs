using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.Customer
{
   public partial class ShowCustomer : UserControl
    {
        List<CustomerModel> tempCustomerTabel;
        public ShowCustomer(List<CustomerModel> customerTable)
        {
            InitializeComponent();
            this.tempCustomerTabel = customerTable;
        }

        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "edit";
            editButton.UseColumnTextForButtonValue = true;
            customerDetails.Columns.Add(editButton);
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "delete";
            deleteButton.UseColumnTextForButtonValue = true;
            customerDetails.Columns.Add(deleteButton);
            customerDetails.DataSource = this.tempCustomerTabel;
            customerDetails.Columns["version"].Visible = false;
        }

        private void customerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid= (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                this.showFormDetails(senderGrid, e,true,"EDIT");
            }
            else
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    this.showFormDetails(senderGrid, e,false,"DELETE");
                }
            }
        }

        public void showFormDetails(DataGridView gridView,DataGridViewCellEventArgs e,Boolean version, String type)
        {
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            CustomerModel customer = new CustomerModel();
            customer.customerId = Convert.ToInt16(row.Cells[2].Value);
            customer.customerName = row.Cells[3].Value.ToString();
            customer.customerMobileNo = row.Cells[4].Value.ToString();
            customer.customerEmail = row.Cells[5].Value.ToString();
            customer.customerAddress = row.Cells[6].Value.ToString();
            if (version)
            {
                customer.version = Convert.ToDouble(row.Cells[7].Value);
            }
            Form formExits = Application.OpenForms["CustomerForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new CustomerForm(customer,type).Show(this);
        }

    }
}
