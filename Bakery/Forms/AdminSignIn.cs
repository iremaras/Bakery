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
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
        {
            InitializeComponent();
        }
        public AdminPage adminPage = new AdminPage();
        public AdminInfo adminInfo = new AdminInfo() { UserName = "İrem", Password = 12345 };
        
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == adminInfo.UserName && textBoxPassword.Text == adminInfo.Password.ToString() )
            {
                adminPage.Show();
            }
        }
    }
}
