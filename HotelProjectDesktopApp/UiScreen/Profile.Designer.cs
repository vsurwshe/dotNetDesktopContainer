namespace HotelDashboard.UiScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.createProfile = new Bunifu.Framework.UI.BunifuTileButton();
            this.profileTableGird = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.profileTableGird)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(21, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 23);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Profile Forms";
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
            // profileTableGird
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profileTableGird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.profileTableGird.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.profileTableGird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileTableGird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileTableGird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.profileTableGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileTableGird.DoubleBuffered = true;
            this.profileTableGird.EnableHeadersVisualStyles = false;
            this.profileTableGird.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.profileTableGird.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.profileTableGird.Location = new System.Drawing.Point(350, 95);
            this.profileTableGird.Name = "profileTableGird";
            this.profileTableGird.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.profileTableGird.Size = new System.Drawing.Size(712, 435);
            this.profileTableGird.TabIndex = 2;
            this.profileTableGird.Visible = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 587);
            this.Controls.Add(this.profileTableGird);
            this.Controls.Add(this.createProfile);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileTableGird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton createProfile;
        private Bunifu.Framework.UI.BunifuCustomDataGrid profileTableGird;
    }
}