
namespace Cars_Dealership_DBProject
{
    partial class Welcome
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
            this.Admin_button = new System.Windows.Forms.Button();
            this.Buyer_button = new System.Windows.Forms.Button();
            this.Seller_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_button
            // 
            this.Admin_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.Admin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Admin_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Admin_button.Location = new System.Drawing.Point(230, 174);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(199, 52);
            this.Admin_button.TabIndex = 1;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = false;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // Buyer_button
            // 
            this.Buyer_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.Buyer_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buyer_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buyer_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Buyer_button.Location = new System.Drawing.Point(27, 246);
            this.Buyer_button.Name = "Buyer_button";
            this.Buyer_button.Size = new System.Drawing.Size(199, 52);
            this.Buyer_button.TabIndex = 4;
            this.Buyer_button.Text = "Buyer / Renter";
            this.Buyer_button.UseVisualStyleBackColor = false;
            // 
            // Seller_button
            // 
            this.Seller_button.BackColor = System.Drawing.Color.MidnightBlue;
            this.Seller_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Seller_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Seller_button.Location = new System.Drawing.Point(433, 246);
            this.Seller_button.Name = "Seller_button";
            this.Seller_button.Size = new System.Drawing.Size(199, 52);
            this.Seller_button.TabIndex = 5;
            this.Seller_button.Text = "Seller";
            this.Seller_button.UseVisualStyleBackColor = false;
            this.Seller_button.Click += new System.EventHandler(this.Seller_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Cars_Dealership_DBProject.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(209, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(644, 355);
            this.Controls.Add(this.Seller_button);
            this.Controls.Add(this.Buyer_button);
            this.Controls.Add(this.Admin_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button Buyer_button;
        private System.Windows.Forms.Button Seller_button;
    }
}

