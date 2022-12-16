using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Admin
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc1 = new AdminFunctionalities();
            AFunc1.Show();

            this.Close(); //To close when clicking back
        }

        private void AddNewAdmin_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Added Successfully");
        }
    }
}
