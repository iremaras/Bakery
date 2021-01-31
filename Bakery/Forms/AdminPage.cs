using Bakery.Data;
using Bakery.Forms;
using Bakery.Services;
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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        public bakeryDbContext dbContext = new bakeryDbContext();
        public AllBusiness allBusiness = new AllBusiness();
        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
        }

        private void buttonAddPage_Click(object sender, EventArgs e)
        {
            AddPage addPage = new AddPage();
            addPage.Show();
        }

        private void buttonUpdatePage_Click(object sender, EventArgs e)
        {
            UpdatePage updatePage = new UpdatePage();
            updatePage.Show();
        }

        private void buttonDeletePage_Click(object sender, EventArgs e)
        {
            RemovePage removePage = new RemovePage();
            removePage.Show();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            CategoryPage categoryPage = new CategoryPage();
            categoryPage.Show();
        }
    }
}
