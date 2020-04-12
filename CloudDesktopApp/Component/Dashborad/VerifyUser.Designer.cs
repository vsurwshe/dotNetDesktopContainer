namespace CloudDesktopApp.Component.Dashborad
{
    partial class VerifyUser
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.verifyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.verifyText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(22, 221);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(261, 10);
            this.progressBar.TabIndex = 15;
            this.progressBar.Visible = false;
            // 
            // verifyButton
            // 
            this.verifyButton.AutoSize = true;
            this.verifyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verifyButton.Depth = 0;
            this.verifyButton.Location = new System.Drawing.Point(65, 164);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.verifyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Primary = true;
            this.verifyButton.Size = new System.Drawing.Size(163, 36);
            this.verifyButton.TabIndex = 17;
            this.verifyButton.Text = "Verify your account";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // verifyText
            // 
            this.verifyText.Depth = 0;
            this.verifyText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verifyText.Hint = "Enter a code, which sent on regsiterd email id";
            this.verifyText.Location = new System.Drawing.Point(26, 123);
            this.verifyText.MouseState = MaterialSkin.MouseState.HOVER;
            this.verifyText.Name = "verifyText";
            this.verifyText.PasswordChar = '\0';
            this.verifyText.SelectedText = "";
            this.verifyText.SelectionLength = 0;
            this.verifyText.SelectionStart = 0;
            this.verifyText.Size = new System.Drawing.Size(247, 23);
            this.verifyText.TabIndex = 16;
            this.verifyText.UseSystemPasswordChar = false;
            // 
            // VerifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 248);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.verifyText);
            this.Controls.Add(this.progressBar);
            this.Name = "VerifyUser";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifying the User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialFlatButton verifyButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField verifyText;
    }
}