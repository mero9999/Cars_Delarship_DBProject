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
    public partial class CarsRequests : Form
    {
        public CarsRequests()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc2 = new AdminFunctionalities();
            AFunc2.Show();

            this.Close();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Car Added to Maintainance");
        }
    }
}
