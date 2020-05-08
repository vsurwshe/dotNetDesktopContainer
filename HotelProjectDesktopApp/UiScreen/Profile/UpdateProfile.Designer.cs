namespace CloudDesktopApp.UiScreen.Profile
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
            this.profileName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.profileType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.updateProfileButton.Location = new System.Drawing.Point(71, 159);
            this.updateProfileButton.Margin = new System.Windows.Forms.Padding(5);
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Size = new System.Drawing.Size(181, 41);
            this.updateProfileButton.TabIndex = 8;
            this.updateProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateProfileButton.Click += new System.EventHandler(this.updateProfileButton_Click);
            // 
            // profileName
            // 
            this.profileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profileName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileName.HintForeColor = System.Drawing.Color.Empty;
            this.profileName.HintText = "Enter Profile Name";
            this.profileName.isPassword = false;
            this.profileName.LineFocusedColor = System.Drawing.Color.Blue;
            this.profileName.LineIdleColor = System.Drawing.Color.Gray;
            this.profileName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.profileName.LineThickness = 4;
            this.profileName.Location = new System.Drawing.Point(33, 97);
            this.profileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(260, 52);
            this.profileName.TabIndex = 7;
            this.profileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Profile Type";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 208);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 11);
            this.progressBar.TabIndex = 15;
            this.progressBar.Visible = false;
            // 
            // profileType
            // 
            this.profileType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.profileType.Enabled = false;
            this.profileType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileType.HintForeColor = System.Drawing.Color.Empty;
            this.profileType.HintText = "Your Profile Type";
            this.profileType.isPassword = false;
            this.profileType.LineFocusedColor = System.Drawing.Color.Blue;
            this.profileType.LineIdleColor = System.Drawing.Color.Gray;
            this.profileType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.profileType.LineThickness = 4;
            this.profileType.Location = new System.Drawing.Point(33, 33);
            this.profileType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileType.Name = "profileType";
            this.profileType.Size = new System.Drawing.Size(260, 52);
            this.profileType.TabIndex = 16;
            this.profileType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 259);
            this.Controls.Add(this.profileType);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UpdateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 updateProfileButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profileName;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profileType;
    }
}