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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Seller_Login Slog2 = new Seller_Login();
            Slog2.Show();

            this.Close();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            // Check correct format of entered password and username and if true go to next form

            SellerFunctionalities Sf1 = new SellerFunctionalities();
            Sf1.Show();

            this.Close();

        }
    }
}
