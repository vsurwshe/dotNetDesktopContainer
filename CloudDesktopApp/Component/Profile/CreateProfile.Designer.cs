namespace CloudDesktopApp.Component.Profile
{
    partial class CreateProfile
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ProfileName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ProfileTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.profile;
            this.materialLabel1.Location = new System.Drawing.Point(121, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 90);
            this.materialLabel1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 192);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(164, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Select the Profile types";
            // 
            // ProfileName
            // 
            this.ProfileName.Depth = 0;
            this.ProfileName.Hint = "Enter the profile name";
            this.ProfileName.Location = new System.Drawing.Point(16, 229);
            this.ProfileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.PasswordChar = '\0';
            this.ProfileName.SelectedText = "";
            this.ProfileName.SelectionLength = 0;
            this.ProfileName.SelectionStart = 0;
            this.ProfileName.Size = new System.Drawing.Size(309, 23);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(107, 278);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(132, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Create a Profile";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // ProfileTypes
            // 
            this.ProfileTypes.FormattingEnabled = true;
            this.ProfileTypes.Location = new System.Drawing.Point(182, 192);
            this.ProfileTypes.Name = "ProfileTypes";
            this.ProfileTypes.Size = new System.Drawing.Size(143, 21);
            this.ProfileTypes.TabIndex = 4;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 467);
            this.Controls.Add(this.ProfileTypes);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProfileName;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox ProfileTypes;
    }
}