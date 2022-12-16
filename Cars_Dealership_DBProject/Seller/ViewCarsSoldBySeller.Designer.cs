
namespace Cars_Dealership_DBProject.Seller
{
    partial class ViewCarsSoldBySeller
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
            this.ViewCarsSoldSeller_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarsSoldSeller_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCarsSoldSeller_dataGridView
            // 
            this.ViewCarsSoldSeller_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCarsSoldSeller_dataGridView.Location = new System.Drawing.Point(57, 42);
            this.ViewCarsSoldSeller_dataGridView.Name = "ViewCarsSoldSeller_dataGridView";
            this.ViewCarsSoldSeller_dataGridView.RowHeadersWidth = 51;
            this.ViewCarsSoldSeller_dataGridView.RowTemplate.Height = 26;
            this.ViewCarsSoldSeller_dataGridView.Size = new System.Drawing.Size(1010, 313);
            this.ViewCarsSoldSeller_dataGridView.TabIndex = 0;
            // 
            // ViewCarsSoldBySeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 420);
            this.Controls.Add(this.ViewCarsSoldSeller_dataGridView);
            this.Name = "ViewCarsSoldBySeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCarsSoldBySeller";
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarsSoldSeller_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewCarsSoldSeller_dataGridView;
    }
}