﻿
namespace Cars_Dealership_DBProject.Admin
{
    partial class AdminFunctionalities
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
            this.Login_button = new System.Windows.Forms.Button();
            this.WhareHouse_button = new System.Windows.Forms.Button();
            this.ApproveCar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Login_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Login_button.Location = new System.Drawing.Point(125, 117);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(266, 63);
            this.Login_button.TabIndex = 8;
            this.Login_button.Text = "Add Admin";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // WhareHouse_button
            // 
            this.WhareHouse_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WhareHouse_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhareHouse_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.WhareHouse_button.Location = new System.Drawing.Point(125, 375);
            this.WhareHouse_button.Name = "WhareHouse_button";
            this.WhareHouse_button.Size = new System.Drawing.Size(266, 70);
            this.WhareHouse_button.TabIndex = 9;
            this.WhareHouse_button.Text = "Move To WhareHouse";
            this.WhareHouse_button.UseVisualStyleBackColor = false;
            this.WhareHouse_button.Click += new System.EventHandler(this.WhareHouse_button_Click);
            // 
            // ApproveCar_button
            // 
            this.ApproveCar_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ApproveCar_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveCar_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ApproveCar_button.Location = new System.Drawing.Point(125, 249);
            this.ApproveCar_button.Name = "ApproveCar_button";
            this.ApproveCar_button.Size = new System.Drawing.Size(266, 63);
            this.ApproveCar_button.TabIndex = 10;
            this.ApproveCar_button.Text = "Approve Car Requests";
            this.ApproveCar_button.UseVisualStyleBackColor = false;
            this.ApproveCar_button.Click += new System.EventHandler(this.ApproveCar_button_Click);
            // 
            // AdminFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 548);
            this.Controls.Add(this.ApproveCar_button);
            this.Controls.Add(this.WhareHouse_button);
            this.Controls.Add(this.Login_button);
            this.Name = "AdminFunctionalities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFunctionalities";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button WhareHouse_button;
        private System.Windows.Forms.Button ApproveCar_button;
    }
}