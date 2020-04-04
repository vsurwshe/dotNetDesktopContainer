namespace CloudDesktopApp.Component.Profile
{
    partial class DeleteProfile
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
            this.profileType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.deleteProfileButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.profileName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // profileType
            // 
            this.profileType.Depth = 0;
            this.profileType.Enabled = false;
            this.profileType.Hint = "Enter the profile Type";
            this.profileType.Location = new System.Drawing.Point(30, 185);
            this.profileType.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileType.Name = "profileType";
            this.profileType.PasswordChar = '\0';
            this.profileType.SelectedText = "";
            this.profileType.SelectionLength = 0;
            this.profileType.SelectionStart = 0;
            this.profileType.Size = new System.Drawing.Size(247, 23);
            this.profileType.TabIndex = 25;
            this.profileType.UseSystemPasswordChar = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 307);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(277, 14);
            this.progressBar.TabIndex = 24;
            this.progressBar.Visible = false;
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.AutoSize = true;
            this.deleteProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteProfileButton.Depth = 0;
            this.deleteProfileButton.Location = new System.Drawing.Point(85, 262);
            this.deleteProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Primary = true;
            this.deleteProfileButton.Size = new System.Drawing.Size(117, 36);
            this.deleteProfileButton.TabIndex = 23;
            this.deleteProfileButton.Text = "Delete Profile";
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // profileName
            // 
            this.profileName.Depth = 0;
            this.profileName.Enabled = false;
            this.profileName.Hint = "Enter the profile name";
            this.profileName.Location = new System.Drawing.Point(30, 230);
            this.profileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileName.Name = "profileName";
            this.profileName.PasswordChar = '\0';
            this.profileName.SelectedText = "";
            this.profileName.SelectionLength = 0;
            this.profileName.SelectionStart = 0;
            this.profileName.Size = new System.Drawing.Size(247, 23);
            this.profileName.TabIndex = 22;
            this.profileName.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.profile;
            this.materialLabel1.Location = new System.Drawing.Point(94, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 90);
            this.materialLabel1.TabIndex = 21;
            // 
            // DeleteProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 351);
            this.Controls.Add(this.profileType);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.deleteProfileButton);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "DeleteProfile";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField profileType;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialFlatButton deleteProfileButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField profileName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}