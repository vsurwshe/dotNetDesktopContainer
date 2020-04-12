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
            this.ProfileName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CreateProfileButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ProfileTypesComboBox = new System.Windows.Forms.ComboBox();
            this.infoProfileTabel = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.profilePayment = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.infoProfileTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.profile;
            this.materialLabel1.Location = new System.Drawing.Point(108, 65);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 85);
            this.materialLabel1.TabIndex = 0;
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
            this.ProfileName.Size = new System.Drawing.Size(282, 23);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.UseSystemPasswordChar = false;
            // 
            // CreateProfileButton
            // 
            this.CreateProfileButton.AutoSize = true;
            this.CreateProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateProfileButton.Depth = 0;
            this.CreateProfileButton.Location = new System.Drawing.Point(85, 261);
            this.CreateProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateProfileButton.Name = "CreateProfileButton";
            this.CreateProfileButton.Primary = true;
            this.CreateProfileButton.Size = new System.Drawing.Size(132, 36);
            this.CreateProfileButton.TabIndex = 3;
            this.CreateProfileButton.Text = "Create a Profile";
            this.CreateProfileButton.UseVisualStyleBackColor = true;
            this.CreateProfileButton.Click += new System.EventHandler(this.CreateProfileButton_Click);
            // 
            // ProfileTypesComboBox
            // 
            this.ProfileTypesComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileTypesComboBox.FormattingEnabled = true;
            this.ProfileTypesComboBox.Location = new System.Drawing.Point(16, 192);
            this.ProfileTypesComboBox.Name = "ProfileTypesComboBox";
            this.ProfileTypesComboBox.Size = new System.Drawing.Size(282, 27);
            this.ProfileTypesComboBox.TabIndex = 4;
            // 
            // infoProfileTabel
            // 
            this.infoProfileTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoProfileTabel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.infoProfileTabel.BackgroundColor = System.Drawing.Color.White;
            this.infoProfileTabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoProfileTabel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.infoProfileTabel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.infoProfileTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoProfileTabel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.infoProfileTabel.Enabled = false;
            this.infoProfileTabel.Location = new System.Drawing.Point(1, 340);
            this.infoProfileTabel.Name = "infoProfileTabel";
            this.infoProfileTabel.RowHeadersVisible = false;
            this.infoProfileTabel.Size = new System.Drawing.Size(358, 152);
            this.infoProfileTabel.TabIndex = 6;
            this.infoProfileTabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 306);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 12);
            this.progressBar.TabIndex = 15;
            this.progressBar.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.Red;
            this.materialLabel2.Location = new System.Drawing.Point(12, 161);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(153, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Your Profile Balance :";
            // 
            // profilePayment
            // 
            this.profilePayment.AutoSize = true;
            this.profilePayment.Depth = 0;
            this.profilePayment.Font = new System.Drawing.Font("Roboto", 11F);
            this.profilePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profilePayment.Location = new System.Drawing.Point(171, 161);
            this.profilePayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.profilePayment.Name = "profilePayment";
            this.profilePayment.Size = new System.Drawing.Size(39, 19);
            this.profilePayment.TabIndex = 17;
            this.profilePayment.Text = "0.0/-";
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 504);
            this.Controls.Add(this.profilePayment);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.infoProfileTabel);
            this.Controls.Add(this.ProfileTypesComboBox);
            this.Controls.Add(this.CreateProfileButton);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CreateProfile";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User Profile";
            this.Load += new System.EventHandler(this.CreateProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoProfileTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProfileName;
        private MaterialSkin.Controls.MaterialFlatButton CreateProfileButton;
        private System.Windows.Forms.ComboBox ProfileTypesComboBox;
        private System.Windows.Forms.DataGridView infoProfileTabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel profilePayment;
    }
}