namespace CloudDesktopApp.Component.Profile
{
    partial class ProfileItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EditButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.profileName = new MaterialSkin.Controls.MaterialLabel();
            this.profileType = new MaterialSkin.Controls.MaterialLabel();
            this.setProfile = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.color = System.Drawing.Color.Transparent;
            this.DeleteButton.colorActive = System.Drawing.Color.Yellow;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Image = global::CloudDesktopApp.Properties.Resources.delete;
            this.DeleteButton.ImagePosition = 10;
            this.DeleteButton.ImageZoom = 35;
            this.DeleteButton.LabelPosition = 10;
            this.DeleteButton.LabelText = "";
            this.DeleteButton.Location = new System.Drawing.Point(46, 127);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 45);
            this.DeleteButton.TabIndex = 29;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.color = System.Drawing.Color.Transparent;
            this.EditButton.colorActive = System.Drawing.Color.Yellow;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Image = global::CloudDesktopApp.Properties.Resources.edit;
            this.EditButton.ImagePosition = 10;
            this.EditButton.ImageZoom = 35;
            this.EditButton.LabelPosition = 10;
            this.EditButton.LabelText = "";
            this.EditButton.Location = new System.Drawing.Point(-2, 127);
            this.EditButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 45);
            this.EditButton.TabIndex = 28;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.profileIcon;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Location = new System.Drawing.Point(19, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 81);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // profileName
            // 
            this.profileName.Depth = 0;
            this.profileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileName.Location = new System.Drawing.Point(3, 81);
            this.profileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(146, 23);
            this.profileName.TabIndex = 30;
            this.profileName.Text = "User ProfileName";
            this.profileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // profileType
            // 
            this.profileType.Depth = 0;
            this.profileType.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileType.Location = new System.Drawing.Point(3, 104);
            this.profileType.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileType.Name = "profileType";
            this.profileType.Size = new System.Drawing.Size(146, 17);
            this.profileType.TabIndex = 31;
            this.profileType.Text = "Profile Type";
            this.profileType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // setProfile
            // 
            this.setProfile.BackColor = System.Drawing.Color.Transparent;
            this.setProfile.color = System.Drawing.Color.Transparent;
            this.setProfile.colorActive = System.Drawing.Color.Yellow;
            this.setProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.setProfile.ForeColor = System.Drawing.Color.Transparent;
            this.setProfile.Image = global::CloudDesktopApp.Properties.Resources.delete;
            this.setProfile.ImagePosition = 10;
            this.setProfile.ImageZoom = 35;
            this.setProfile.LabelPosition = 10;
            this.setProfile.LabelText = "";
            this.setProfile.Location = new System.Drawing.Point(96, 127);
            this.setProfile.Margin = new System.Windows.Forms.Padding(6);
            this.setProfile.Name = "setProfile";
            this.setProfile.Size = new System.Drawing.Size(50, 45);
            this.setProfile.TabIndex = 32;
            this.setProfile.Click += new System.EventHandler(this.setProfile_Click);
            // 
            // ProfileItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.setProfile);
            this.Controls.Add(this.profileType);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.materialLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "ProfileItems";
            this.Size = new System.Drawing.Size(152, 178);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuTileButton EditButton;
        private Bunifu.Framework.UI.BunifuTileButton DeleteButton;
        private MaterialSkin.Controls.MaterialLabel profileName;
        private MaterialSkin.Controls.MaterialLabel profileType;
        private Bunifu.Framework.UI.BunifuTileButton setProfile;
    }
}
