namespace HotelDashboard
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cancleButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signUpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.password);
            this.bunifuCards1.Controls.Add(this.cancleButton);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.signUpButton);
            this.bunifuCards1.Controls.Add(this.email);
            this.bunifuCards1.Controls.Add(this.name);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(441, 419);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.GreenYellow;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.GreenYellow;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login Account";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(294, 373);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(98, 17);
            this.bunifuThinButton21.TabIndex = 19;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(52, 373);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(245, 17);
            this.bunifuCustomLabel4.TabIndex = 18;
            this.bunifuCustomLabel4.Text = "I have an account  ? for login click here ";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HintForeColor = System.Drawing.Color.Blue;
            this.password.HintText = "Enter password";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.Blue;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.password.LineThickness = 1;
            this.password.Location = new System.Drawing.Point(72, 260);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(320, 25);
            this.password.TabIndex = 17;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cancleButton
            // 
            this.cancleButton.ActiveBorderThickness = 1;
            this.cancleButton.ActiveCornerRadius = 20;
            this.cancleButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cancleButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancleButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cancleButton.BackColor = System.Drawing.Color.White;
            this.cancleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancleButton.BackgroundImage")));
            this.cancleButton.ButtonText = "Cancel";
            this.cancleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancleButton.ForeColor = System.Drawing.Color.Green;
            this.cancleButton.IdleBorderThickness = 1;
            this.cancleButton.IdleCornerRadius = 20;
            this.cancleButton.IdleFillColor = System.Drawing.Color.White;
            this.cancleButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cancleButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cancleButton.Location = new System.Drawing.Point(223, 308);
            this.cancleButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(140, 37);
            this.cancleButton.TabIndex = 16;
            this.cancleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HotelDashboard.Properties.Resources.userVectorImages;
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // signUpButton
            // 
            this.signUpButton.ActiveBorderThickness = 1;
            this.signUpButton.ActiveCornerRadius = 20;
            this.signUpButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.ActiveForecolor = System.Drawing.Color.White;
            this.signUpButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.BackColor = System.Drawing.Color.White;
            this.signUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpButton.BackgroundImage")));
            this.signUpButton.ButtonText = "Signup User";
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.Green;
            this.signUpButton.IdleBorderThickness = 1;
            this.signUpButton.IdleCornerRadius = 20;
            this.signUpButton.IdleFillColor = System.Drawing.Color.White;
            this.signUpButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.signUpButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.Location = new System.Drawing.Point(61, 308);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(140, 37);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HintForeColor = System.Drawing.Color.Blue;
            this.email.HintText = "Enter email address";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Blue;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.email.LineThickness = 1;
            this.email.Location = new System.Drawing.Point(72, 209);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(320, 25);
            this.email.TabIndex = 13;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.Blue;
            this.name.HintForeColor = System.Drawing.Color.Blue;
            this.name.HintText = "Enter full name";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Blue;
            this.name.LineIdleColor = System.Drawing.Color.Black;
            this.name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name.LineThickness = 1;
            this.name.Location = new System.Drawing.Point(72, 143);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(320, 37);
            this.name.TabIndex = 12;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 419);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User Details";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancleButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}