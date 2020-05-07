namespace CloudDesktopApp.Component.Customer
{
    partial class CustomerManagment
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.customerCreate = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(166, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Customer Management";
            // 
            // customerCreate
            // 
            this.customerCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerCreate.Depth = 0;
            this.customerCreate.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerCreate.Image = global::CloudDesktopApp.Properties.Resources.profile;
            this.customerCreate.Location = new System.Drawing.Point(28, 102);
            this.customerCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerCreate.Name = "customerCreate";
            this.customerCreate.Size = new System.Drawing.Size(119, 121);
            this.customerCreate.TabIndex = 4;
            this.customerCreate.Text = "Add Customer";
            this.customerCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerCreate.Click += new System.EventHandler(this.customerCreate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(242, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 471);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // CustomerManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 741);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.customerCreate);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManagment";
            this.Text = "CustomerManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel customerCreate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}