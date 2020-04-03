namespace CloudDesktopApp.Component.Profile
{
    partial class ProfileItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EditButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.profileName = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.color = System.Drawing.Color.Transparent;
            this.DeleteButton.colorActive = System.Drawing.Color.Yellow;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Image = global::CloudDesktopApp.Properties.Resources.delete;
            this.DeleteButton.ImagePosition = 10;
            this.DeleteButton.ImageZoom = 35;
            this.DeleteButton.LabelPosition = 10;
            this.DeleteButton.LabelText = "";
            this.DeleteButton.Location = new System.Drawing.Point(74, 120);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 45);
            this.DeleteButton.TabIndex = 29;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.color = System.Drawing.Color.Transparent;
            this.EditButton.colorActive = System.Drawing.Color.Yellow;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Image = global::CloudDesktopApp.Properties.Resources.edit;
            this.EditButton.ImagePosition = 10;
            this.EditButton.ImageZoom = 35;
            this.EditButton.LabelPosition = 10;
            this.EditButton.LabelText = "";
            this.EditButton.Location = new System.Drawing.Point(20, 120);
            this.EditButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 45);
            this.EditButton.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.profileIcon;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Location = new System.Drawing.Point(16, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 91);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Depth = 0;
            this.profileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileName.Location = new System.Drawing.Point(16, 91);
            this.profileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(128, 19);
            this.profileName.TabIndex = 30;
            this.profileName.Text = "User ProfileName";
            // 
            // ProfileItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ProfileItems";
            this.Size = new System.Drawing.Size(152, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuTileButton EditButton;
        private Bunifu.Framework.UI.BunifuTileButton DeleteButton;
        private MaterialSkin.Controls.MaterialLabel profileName;
    }
}
