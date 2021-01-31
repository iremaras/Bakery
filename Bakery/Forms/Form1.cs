using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        public AdminPage adminPage = new AdminPage();
        public AdminSignIn adminSignIn = new AdminSignIn();
        private void buttonAdminSignIn_Click(object sender, EventArgs e)
        {
            adminSignIn.Show();
        }

        public ShoppingPage shoppingPage = new ShoppingPage();
        private void button1_Click(object sender, EventArgs e)
        {
            shoppingPage.Show();
        }
    }
 }
