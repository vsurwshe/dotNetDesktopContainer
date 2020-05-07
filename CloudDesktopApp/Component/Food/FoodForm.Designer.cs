namespace CloudDesktopApp.Component.Food
{
    partial class FoodForm
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
            this.saveFoodButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.foodCategory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.foodPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.foodName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 258);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 12);
            this.progressBar.TabIndex = 18;
            this.progressBar.Visible = false;
            // 
            // saveFoodButton
            // 
            this.saveFoodButton.AutoSize = true;
            this.saveFoodButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveFoodButton.Depth = 0;
            this.saveFoodButton.Location = new System.Drawing.Point(75, 213);
            this.saveFoodButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveFoodButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveFoodButton.Name = "saveFoodButton";
            this.saveFoodButton.Primary = true;
            this.saveFoodButton.Size = new System.Drawing.Size(142, 36);
            this.saveFoodButton.TabIndex = 17;
            this.saveFoodButton.Text = "Save Food Details";
            this.saveFoodButton.UseVisualStyleBackColor = true;
            // 
            // foodCategory
            // 
            this.foodCategory.Depth = 0;
            this.foodCategory.Hint = "Enter the food category";
            this.foodCategory.Location = new System.Drawing.Point(16, 181);
            this.foodCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodCategory.Name = "foodCategory";
            this.foodCategory.PasswordChar = '\0';
            this.foodCategory.SelectedText = "";
            this.foodCategory.SelectionLength = 0;
            this.foodCategory.SelectionStart = 0;
            this.foodCategory.Size = new System.Drawing.Size(282, 23);
            this.foodCategory.TabIndex = 16;
            this.foodCategory.UseSystemPasswordChar = false;
            // 
            // foodPrice
            // 
            this.foodPrice.Depth = 0;
            this.foodPrice.Hint = "Enter the food price";
            this.foodPrice.Location = new System.Drawing.Point(16, 132);
            this.foodPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.PasswordChar = '\0';
            this.foodPrice.SelectedText = "";
            this.foodPrice.SelectionLength = 0;
            this.foodPrice.SelectionStart = 0;
            this.foodPrice.Size = new System.Drawing.Size(282, 23);
            this.foodPrice.TabIndex = 19;
            this.foodPrice.UseSystemPasswordChar = false;
            // 
            // foodName
            // 
            this.foodName.Depth = 0;
            this.foodName.Hint = "Enter the food name";
            this.foodName.Location = new System.Drawing.Point(16, 88);
            this.foodName.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodName.Name = "foodName";
            this.foodName.PasswordChar = '\0';
            this.foodName.SelectedText = "";
            this.foodName.SelectionLength = 0;
            this.foodName.SelectionStart = 0;
            this.foodName.Size = new System.Drawing.Size(282, 23);
            this.foodName.TabIndex = 20;
            this.foodName.UseSystemPasswordChar = false;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 282);
            this.Controls.Add(this.foodName);
            this.Controls.Add(this.foodPrice);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveFoodButton);
            this.Controls.Add(this.foodCategory);
            this.Name = "FoodForm";
            this.Text = "Food Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialFlatButton saveFoodButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField foodCategory;
        private MaterialSkin.Controls.MaterialSingleLineTextField foodPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField foodName;
    }
}