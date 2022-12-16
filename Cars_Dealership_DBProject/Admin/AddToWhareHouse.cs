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
    public partial class AddToWhareHouse : Form
    {
        public AddToWhareHouse()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc3 = new AdminFunctionalities();
            AFunc3.Show();

            this.Close();
        }

        private void Move_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Car Moved to WhareHouse");
        }
    }
}
