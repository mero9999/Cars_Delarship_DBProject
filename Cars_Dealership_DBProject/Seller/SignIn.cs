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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Seller_Login Slog1 = new Seller_Login();
            Slog1.Show();

            this.Close();

        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            // Check for username and password and if true go to next form

            SellerFunctionalities Sf = new SellerFunctionalities();
            Sf.Show();

            this.Close();

        }
    }
}
