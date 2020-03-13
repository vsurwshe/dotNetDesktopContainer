namespace HotelDashboard.UiScreen.Profile
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BunifuCards9 = new Bunifu.Framework.UI.BunifuCards();
            this.BunifuCustomLabel26 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.createProfile = new Bunifu.Framework.UI.BunifuTileButton();
            this.profilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BunifuCards9.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(21, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(179, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Profile Management";
            // 
            // BunifuCards9
            // 
            this.BunifuCards9.BackColor = System.Drawing.Color.White;
            this.BunifuCards9.BorderRadius = 2;
            this.BunifuCards9.BottomSahddow = false;
            this.BunifuCards9.color = System.Drawing.Color.White;
            this.BunifuCards9.Controls.Add(this.profilePanel);
            this.BunifuCards9.Controls.Add(this.BunifuCustomLabel26);
            this.BunifuCards9.LeftSahddow = false;
            this.BunifuCards9.Location = new System.Drawing.Point(288, 95);
            this.BunifuCards9.Name = "BunifuCards9";
            this.BunifuCards9.RightSahddow = false;
            this.BunifuCards9.ShadowDepth = 20;
            this.BunifuCards9.Size = new System.Drawing.Size(702, 480);
            this.BunifuCards9.TabIndex = 26;
            // 
            // BunifuCustomLabel26
            // 
            this.BunifuCustomLabel26.AutoSize = true;
            this.BunifuCustomLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BunifuCustomLabel26.ForeColor = System.Drawing.Color.Black;
            this.BunifuCustomLabel26.Location = new System.Drawing.Point(12, 12);
            this.BunifuCustomLabel26.Name = "BunifuCustomLabel26";
            this.BunifuCustomLabel26.Size = new System.Drawing.Size(84, 16);
            this.BunifuCustomLabel26.TabIndex = 17;
            this.BunifuCustomLabel26.Text = "Your Profiles";
            // 
            // createProfile
            // 
            this.createProfile.BackColor = System.Drawing.Color.SeaGreen;
            this.createProfile.color = System.Drawing.Color.SeaGreen;
            this.createProfile.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.createProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.createProfile.ForeColor = System.Drawing.Color.White;
            this.createProfile.Image = ((System.Drawing.Image)(resources.GetObject("createProfile.Image")));
            this.createProfile.ImagePosition = 20;
            this.createProfile.ImageZoom = 50;
            this.createProfile.LabelPosition = 41;
            this.createProfile.LabelText = "Create Profile";
            this.createProfile.Location = new System.Drawing.Point(54, 95);
            this.createProfile.Margin = new System.Windows.Forms.Padding(6);
            this.createProfile.Name = "createProfile";
            this.createProfile.Size = new System.Drawing.Size(185, 143);
            this.createProfile.TabIndex = 1;
            this.createProfile.Click += new System.EventHandler(this.createProfile_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.Location = new System.Drawing.Point(15, 56);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(670, 408);
            this.profilePanel.TabIndex = 18;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 587);
            this.Controls.Add(this.BunifuCards9);
            this.Controls.Add(this.createProfile);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.BunifuCards9.ResumeLayout(false);
            this.BunifuCards9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton createProfile;
        internal Bunifu.Framework.UI.BunifuCards BunifuCards9;
        internal Bunifu.Framework.UI.BunifuCustomLabel BunifuCustomLabel26;
        private System.Windows.Forms.FlowLayoutPanel profilePanel;
    }
}