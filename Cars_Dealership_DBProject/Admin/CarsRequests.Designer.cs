
namespace Cars_Dealership_DBProject.Admin
{
    partial class CarsRequests
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SellerName_comboBox = new System.Windows.Forms.ComboBox();
            this.ViewSellerCars_dataGridView = new System.Windows.Forms.DataGridView();
            this.CarVIN_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Accepted_radioButton = new System.Windows.Forms.RadioButton();
            this.Rejected_radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.MaintainanceCenter_comboBox = new System.Windows.Forms.ComboBox();
            this.Done_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSellerCars_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seller Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car VIN";
            // 
            // SellerName_comboBox
            // 
            this.SellerName_comboBox.FormattingEnabled = true;
            this.SellerName_comboBox.Location = new System.Drawing.Point(144, 40);
            this.SellerName_comboBox.Name = "SellerName_comboBox";
            this.SellerName_comboBox.Size = new System.Drawing.Size(165, 29);
            this.SellerName_comboBox.TabIndex = 4;
            // 
            // ViewSellerCars_dataGridView
            // 
            this.ViewSellerCars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSellerCars_dataGridView.Location = new System.Drawing.Point(10, 94);
            this.ViewSellerCars_dataGridView.Name = "ViewSellerCars_dataGridView";
            this.ViewSellerCars_dataGridView.RowHeadersWidth = 51;
            this.ViewSellerCars_dataGridView.RowTemplate.Height = 26;
            this.ViewSellerCars_dataGridView.Size = new System.Drawing.Size(810, 88);
            this.ViewSellerCars_dataGridView.TabIndex = 5;
            // 
            // CarVIN_comboBox
            // 
            this.CarVIN_comboBox.FormattingEnabled = true;
            this.CarVIN_comboBox.Location = new System.Drawing.Point(117, 49);
            this.CarVIN_comboBox.Name = "CarVIN_comboBox";
            this.CarVIN_comboBox.Size = new System.Drawing.Size(138, 29);
            this.CarVIN_comboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewSellerCars_dataGridView);
            this.groupBox1.Controls.Add(this.SellerName_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Cars by Seller";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Back_button);
            this.groupBox2.Controls.Add(this.Done_button);
            this.groupBox2.Controls.Add(this.MaintainanceCenter_comboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Rejected_radioButton);
            this.groupBox2.Controls.Add(this.Accepted_radioButton);
            this.groupBox2.Controls.Add(this.CarVIN_comboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 278);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Car";
            // 
            // Accepted_radioButton
            // 
            this.Accepted_radioButton.AutoSize = true;
            this.Accepted_radioButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accepted_radioButton.Location = new System.Drawing.Point(18, 118);
            this.Accepted_radioButton.Name = "Accepted_radioButton";
            this.Accepted_radioButton.Size = new System.Drawing.Size(110, 25);
            this.Accepted_radioButton.TabIndex = 7;
            this.Accepted_radioButton.TabStop = true;
            this.Accepted_radioButton.Text = "Accepted";
            this.Accepted_radioButton.UseVisualStyleBackColor = true;
            // 
            // Rejected_radioButton
            // 
            this.Rejected_radioButton.AutoSize = true;
            this.Rejected_radioButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejected_radioButton.Location = new System.Drawing.Point(18, 174);
            this.Rejected_radioButton.Name = "Rejected_radioButton";
            this.Rejected_radioButton.Size = new System.Drawing.Size(106, 25);
            this.Rejected_radioButton.TabIndex = 8;
            this.Rejected_radioButton.TabStop = true;
            this.Rejected_radioButton.Text = "Rejected";
            this.Rejected_radioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(221, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maintainance Center";
            // 
            // MaintainanceCenter_comboBox
            // 
            this.MaintainanceCenter_comboBox.FormattingEnabled = true;
            this.MaintainanceCenter_comboBox.Location = new System.Drawing.Point(450, 117);
            this.MaintainanceCenter_comboBox.Name = "MaintainanceCenter_comboBox";
            this.MaintainanceCenter_comboBox.Size = new System.Drawing.Size(138, 29);
            this.MaintainanceCenter_comboBox.TabIndex = 10;
            // 
            // Done_button
            // 
            this.Done_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Done_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Done_button.Location = new System.Drawing.Point(706, 218);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(179, 41);
            this.Done_button.TabIndex = 11;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = false;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_button.Location = new System.Drawing.Point(504, 218);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(180, 41);
            this.Back_button.TabIndex = 12;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // CarsRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarsRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsRequests";
            ((System.ComponentModel.ISupportInitialize)(this.ViewSellerCars_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SellerName_comboBox;
        private System.Windows.Forms.DataGridView ViewSellerCars_dataGridView;
        private System.Windows.Forms.ComboBox CarVIN_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MaintainanceCenter_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Rejected_radioButton;
        private System.Windows.Forms.RadioButton Accepted_radioButton;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Button Back_button;
    }
}