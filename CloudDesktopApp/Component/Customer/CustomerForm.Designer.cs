namespace CloudDesktopApp.Component.Customer
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.customerMobileNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.saveCustomerButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.customerEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.customerAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Depth = 0;
            this.customerName.Hint = "Enter the customer name";
            this.customerName.Location = new System.Drawing.Point(11, 77);
            this.customerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerName.Name = "customerName";
            this.customerName.PasswordChar = '\0';
            this.customerName.SelectedText = "";
            this.customerName.SelectionLength = 0;
            this.customerName.SelectionStart = 0;
            this.customerName.Size = new System.Drawing.Size(282, 23);
            this.customerName.TabIndex = 30;
            this.customerName.UseSystemPasswordChar = false;
            // 
            // customerMobileNo
            // 
            this.customerMobileNo.Depth = 0;
            this.customerMobileNo.Hint = "Enter the customer mobile number";
            this.customerMobileNo.Location = new System.Drawing.Point(11, 121);
            this.customerMobileNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerMobileNo.Name = "customerMobileNo";
            this.customerMobileNo.PasswordChar = '\0';
            this.customerMobileNo.SelectedText = "";
            this.customerMobileNo.SelectionLength = 0;
            this.customerMobileNo.SelectionStart = 0;
            this.customerMobileNo.Size = new System.Drawing.Size(282, 23);
            this.customerMobileNo.TabIndex = 29;
            this.customerMobileNo.UseSystemPasswordChar = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 298);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 12);
            this.progressBar.TabIndex = 28;
            this.progressBar.Visible = false;
            // 
            // saveCustomerButton
            // 
            this.saveCustomerButton.AutoSize = true;
            this.saveCustomerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveCustomerButton.Depth = 0;
            this.saveCustomerButton.Location = new System.Drawing.Point(57, 253);
            this.saveCustomerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveCustomerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveCustomerButton.Name = "saveCustomerButton";
            this.saveCustomerButton.Primary = true;
            this.saveCustomerButton.Size = new System.Drawing.Size(179, 36);
            this.saveCustomerButton.TabIndex = 27;
            this.saveCustomerButton.Text = "Save Customer Details";
            this.saveCustomerButton.UseVisualStyleBackColor = true;
            this.saveCustomerButton.Click += new System.EventHandler(this.saveHotelTabelButton_Click);
            // 
            // customerEmail
            // 
            this.customerEmail.Depth = 0;
            this.customerEmail.Hint = "Enter the customer email id";
            this.customerEmail.Location = new System.Drawing.Point(11, 163);
            this.customerEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.PasswordChar = '\0';
            this.customerEmail.SelectedText = "";
            this.customerEmail.SelectionLength = 0;
            this.customerEmail.SelectionStart = 0;
            this.customerEmail.Size = new System.Drawing.Size(282, 23);
            this.customerEmail.TabIndex = 26;
            this.customerEmail.UseSystemPasswordChar = false;
            // 
            // customerAddress
            // 
            this.customerAddress.Depth = 0;
            this.customerAddress.Hint = "Enter the customer address";
            this.customerAddress.Location = new System.Drawing.Point(11, 208);
            this.customerAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.PasswordChar = '\0';
            this.customerAddress.SelectedText = "";
            this.customerAddress.SelectionLength = 0;
            this.customerAddress.SelectionStart = 0;
            this.customerAddress.Size = new System.Drawing.Size(282, 23);
            this.customerAddress.TabIndex = 31;
            this.customerAddress.UseSystemPasswordChar = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 322);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerMobileNo);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveCustomerButton);
            this.Controls.Add(this.customerEmail);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField customerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField customerMobileNo;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialFlatButton saveCustomerButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField customerEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField customerAddress;
    }
}