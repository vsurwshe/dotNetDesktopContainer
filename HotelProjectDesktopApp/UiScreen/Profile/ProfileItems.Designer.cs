namespace HotelDashboard.UiScreen.Profile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileItems));
            this.subtitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.subject = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.task_image = new System.Windows.Forms.PictureBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.edit = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.task_image)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.SuspendLayout();
            // 
            // subtitle
            // 
            this.subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitle.AutoEllipsis = true;
            this.subtitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.subtitle.Location = new System.Drawing.Point(17, 109);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(171, 26);
            this.subtitle.TabIndex = 46;
            this.subtitle.Text = "TASK SUBTITLE";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subject
            // 
            this.subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subject.AutoEllipsis = true;
            this.subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subject.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.ForeColor = System.Drawing.Color.Black;
            this.subject.Location = new System.Drawing.Point(17, 83);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(171, 26);
            this.subject.TabIndex = 45;
            this.subject.Text = "TASK LABEL";
            this.subject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // task_image
            // 
            this.task_image.Image = ((System.Drawing.Image)(resources.GetObject("task_image.Image")));
            this.task_image.Location = new System.Drawing.Point(73, 14);
            this.task_image.Name = "task_image";
            this.task_image.Size = new System.Drawing.Size(56, 56);
            this.task_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.task_image.TabIndex = 44;
            this.task_image.TabStop = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.subject);
            this.bunifuCards1.Controls.Add(this.subtitle);
            this.bunifuCards1.Controls.Add(this.task_image);
            this.bunifuCards1.Controls.Add(this.delete);
            this.bunifuCards1.Controls.Add(this.edit);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, -1);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(205, 176);
            this.bunifuCards1.TabIndex = 48;
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageActive = null;
            this.delete.Location = new System.Drawing.Point(104, 138);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(25, 23);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete.TabIndex = 48;
            this.delete.TabStop = false;
            this.delete.Zoom = 10;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.ImageActive = null;
            this.edit.Location = new System.Drawing.Point(58, 140);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(25, 21);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit.TabIndex = 49;
            this.edit.TabStop = false;
            this.edit.Zoom = 10;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // ProfileItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ProfileItems";
            this.Size = new System.Drawing.Size(201, 174);
            ((System.ComponentModel.ISupportInitialize)(this.task_image)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Bunifu.Framework.UI.BunifuCustomLabel subtitle;
        internal Bunifu.Framework.UI.BunifuCustomLabel subject;
        internal System.Windows.Forms.PictureBox task_image;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        internal Bunifu.Framework.UI.BunifuImageButton edit;
        internal Bunifu.Framework.UI.BunifuImageButton delete;
    }
}