using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Seller
{
    public partial class OfferNewCar : Form
    {
        public OfferNewCar()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            SellerFunctionalities Sf1 = new SellerFunctionalities();
            Sf1.Show();

            this.Close();
        }
    }
}
