namespace CloudDesktopApp.Component.Dashborad
{
    partial class CommonDashborad
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
            this.notVerifyMessageBox = new Bunifu.Framework.UI.BunifuCards();
            this.notVerifyMessageLable = new MaterialSkin.Controls.MaterialLabel();
            this.verifyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.notVerifyMessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(39, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Common Dashborad";
            // 
            // notVerifyMessageBox
            // 
            this.notVerifyMessageBox.BackColor = System.Drawing.Color.White;
            this.notVerifyMessageBox.BorderRadius = 5;
            this.notVerifyMessageBox.BottomSahddow = true;
            this.notVerifyMessageBox.color = System.Drawing.Color.Lime;
            this.notVerifyMessageBox.Controls.Add(this.verifyButton);
            this.notVerifyMessageBox.Controls.Add(this.notVerifyMessageLable);
            this.notVerifyMessageBox.LeftSahddow = false;
            this.notVerifyMessageBox.Location = new System.Drawing.Point(415, 280);
            this.notVerifyMessageBox.Name = "notVerifyMessageBox";
            this.notVerifyMessageBox.RightSahddow = true;
            this.notVerifyMessageBox.ShadowDepth = 20;
            this.notVerifyMessageBox.Size = new System.Drawing.Size(363, 141);
            this.notVerifyMessageBox.TabIndex = 1;
            this.notVerifyMessageBox.Visible = false;
            // 
            // notVerifyMessageLable
            // 
            this.notVerifyMessageLable.AutoSize = true;
            this.notVerifyMessageLable.Depth = 0;
            this.notVerifyMessageLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.notVerifyMessageLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notVerifyMessageLable.Location = new System.Drawing.Point(3, 26);
            this.notVerifyMessageLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.notVerifyMessageLable.Name = "notVerifyMessageLable";
            this.notVerifyMessageLable.Size = new System.Drawing.Size(108, 19);
            this.notVerifyMessageLable.TabIndex = 1;
            this.notVerifyMessageLable.Text = "materialLabel2";
            this.notVerifyMessageLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verifyButton
            // 
            this.verifyButton.AutoSize = true;
            this.verifyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verifyButton.Depth = 0;
            this.verifyButton.Location = new System.Drawing.Point(102, 90);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.verifyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Primary = true;
            this.verifyButton.Size = new System.Drawing.Size(163, 36);
            this.verifyButton.TabIndex = 2;
            this.verifyButton.Text = "Verify Your Account";
            this.verifyButton.UseVisualStyleBackColor = true;
            // 
            // CommonDashborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 433);
            this.Controls.Add(this.notVerifyMessageBox);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommonDashborad";
            this.Text = "CommonDashborad";
            this.Load += new System.EventHandler(this.CommonDashborad_Load);
            this.notVerifyMessageBox.ResumeLayout(false);
            this.notVerifyMessageBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuCards notVerifyMessageBox;
        private MaterialSkin.Controls.MaterialFlatButton verifyButton;
        private MaterialSkin.Controls.MaterialLabel notVerifyMessageLable;
    }
}