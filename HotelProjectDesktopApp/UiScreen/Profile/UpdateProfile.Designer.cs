namespace HotelDashboard.UiScreen.Profile
{
    partial class UpdateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProfile));
            this.updateProfileButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.profileNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.profileTypeDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.ActiveBorderThickness = 1;
            this.updateProfileButton.ActiveCornerRadius = 20;
            this.updateProfileButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updateProfileButton.ActiveForecolor = System.Drawing.Color.White;
            this.updateProfileButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updateProfileButton.BackColor = System.Drawing.SystemColors.Control;
            this.updateProfileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateProfileButton.BackgroundImage")));
            this.updateProfileButton.ButtonText = "Update Profile";
            this.updateProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfileButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.updateProfileButton.IdleBorderThickness = 1;
            this.updateProfileButton.IdleCornerRadius = 20;
            this.updateProfileButton.IdleFillColor = System.Drawing.Color.White;
            this.updateProfileButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.updateProfileButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updateProfileButton.Location = new System.Drawing.Point(72, 141);
            this.updateProfileButton.Margin = new System.Windows.Forms.Padding(5);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(181, 41);
            this.updateProfileButton.TabIndex = 8;
            this.updateProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileNameText
            // 
            this.profileNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profileNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileNameText.HintForeColor = System.Drawing.Color.Empty;
            this.profileNameText.HintText = "Enter Profile Name";
            this.profileNameText.isPassword = false;
            this.profileNameText.LineFocusedColor = System.Drawing.Color.Blue;
            this.profileNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.profileNameText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.profileNameText.LineThickness = 4;
            this.profileNameText.Location = new System.Drawing.Point(33, 79);
            this.profileNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileNameText.Name = "profileNameText";
            this.profileNameText.Size = new System.Drawing.Size(260, 52);
            this.profileNameText.TabIndex = 7;
            this.profileNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Profile Type";
            // 
            // profileTypeDrop
            // 
            this.profileTypeDrop.BackColor = System.Drawing.Color.Transparent;
            this.profileTypeDrop.BorderRadius = 3;
            this.profileTypeDrop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileTypeDrop.ForeColor = System.Drawing.Color.White;
            this.profileTypeDrop.Items = new string[0];
            this.profileTypeDrop.Location = new System.Drawing.Point(33, 35);
            this.profileTypeDrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profileTypeDrop.Name = "profileTypeDrop";
            this.profileTypeDrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.profileTypeDrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.profileTypeDrop.selectedIndex = -1;
            this.profileTypeDrop.Size = new System.Drawing.Size(258, 35);
            this.profileTypeDrop.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 190);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 11);
            this.progressBar.TabIndex = 15;
            this.progressBar.Visible = false;
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 220);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.profileNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileTypeDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UpdateProfile";
            this.Text = "Update Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 updateProfileButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profileNameText;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown profileTypeDrop;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}