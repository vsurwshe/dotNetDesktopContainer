namespace CloudDesktopApp.Component.Profile
{
    partial class ProfileManagement
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
            this.UserProfileLable = new MaterialSkin.Controls.MaterialLabel();
            this.profilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profileCreate = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "User Profile Management";
            // 
            // UserProfileLable
            // 
            this.UserProfileLable.Depth = 0;
            this.UserProfileLable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UserProfileLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserProfileLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserProfileLable.Location = new System.Drawing.Point(252, 68);
            this.UserProfileLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserProfileLable.Name = "UserProfileLable";
            this.UserProfileLable.Size = new System.Drawing.Size(152, 19);
            this.UserProfileLable.TabIndex = 1;
            this.UserProfileLable.Text = "Your Created Profiles";
            this.UserProfileLable.Visible = false;
            // 
            // profilePanel
            // 
            this.profilePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePanel.Location = new System.Drawing.Point(247, 90);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1002, 550);
            this.profilePanel.TabIndex = 2;
            // 
            // profileCreate
            // 
            this.profileCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileCreate.Depth = 0;
            this.profileCreate.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileCreate.Image = global::CloudDesktopApp.Properties.Resources.profile;
            this.profileCreate.Location = new System.Drawing.Point(12, 68);
            this.profileCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileCreate.Name = "profileCreate";
            this.profileCreate.Size = new System.Drawing.Size(119, 121);
            this.profileCreate.TabIndex = 3;
            this.profileCreate.Text = "Create Profile";
            this.profileCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.profileCreate.Click += new System.EventHandler(this.profileCreate_Click);
            // 
            // ProfileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 636);
            this.Controls.Add(this.profileCreate);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.UserProfileLable);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileManagement";
            this.Text = "ProfileManagement";
            this.Load += new System.EventHandler(this.ProfileManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel UserProfileLable;
        private System.Windows.Forms.FlowLayoutPanel profilePanel;
        private MaterialSkin.Controls.MaterialLabel profileCreate;
    }
}