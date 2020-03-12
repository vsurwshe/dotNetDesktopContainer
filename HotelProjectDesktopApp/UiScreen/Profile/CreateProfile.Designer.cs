namespace HotelDashboard.UiScreen.Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfile));
            this.profileTypeDrop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.profileNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.infoProfileTabel = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.infoProfileTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // profileTypeDrop
            // 
            this.profileTypeDrop.BackColor = System.Drawing.Color.Transparent;
            this.profileTypeDrop.BorderRadius = 3;
            this.profileTypeDrop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileTypeDrop.ForeColor = System.Drawing.Color.White;
            this.profileTypeDrop.Items = new string[0];
            this.profileTypeDrop.Location = new System.Drawing.Point(70, 46);
            this.profileTypeDrop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profileTypeDrop.Name = "profileTypeDrop";
            this.profileTypeDrop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.profileTypeDrop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.profileTypeDrop.selectedIndex = -1;
            this.profileTypeDrop.Size = new System.Drawing.Size(258, 35);
            this.profileTypeDrop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Profile Type";
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
            this.profileNameText.Location = new System.Drawing.Point(68, 79);
            this.profileNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileNameText.Name = "profileNameText";
            this.profileNameText.Size = new System.Drawing.Size(260, 52);
            this.profileNameText.TabIndex = 3;
            this.profileNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoProfileTabel
            // 
            this.infoProfileTabel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoProfileTabel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.infoProfileTabel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.infoProfileTabel.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.infoProfileTabel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.infoProfileTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoProfileTabel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.infoProfileTabel.Enabled = false;
            this.infoProfileTabel.Location = new System.Drawing.Point(2, 206);
            this.infoProfileTabel.Name = "infoProfileTabel";
            this.infoProfileTabel.RowHeadersVisible = false;
            this.infoProfileTabel.Size = new System.Drawing.Size(416, 258);
            this.infoProfileTabel.TabIndex = 5;
            this.infoProfileTabel.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Create Profile";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(119, 141);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(58, 190);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 10);
            this.progressBar.TabIndex = 14;
            this.progressBar.Visible = false;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 458);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.infoProfileTabel);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.profileNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileTypeDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a Profile";
            ((System.ComponentModel.ISupportInitialize)(this.infoProfileTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown profileTypeDrop;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox profileNameText;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.DataGridView infoProfileTabel;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}