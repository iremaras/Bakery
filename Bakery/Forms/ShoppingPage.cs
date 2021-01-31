using Bakery.Data;
using Bakery.Models;
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
    public partial class ShoppingPage : Form
    {
        public ShoppingPage()
        {
            InitializeComponent();
        }
        AllBusiness allBusiness = new AllBusiness();
        bakeryDbContext dbContext = new bakeryDbContext();
        private void ShoppingPage_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
            comboBoxProducts.DataSource = allBusiness.GetProducts();
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
        }
        Product selectedProduct = null;
        private void comboBoxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Product product = new Product();
            product = allBusiness.GetProductsById((int)comboBoxProducts.SelectedValue);
            selectedProduct = product;
        }

        private void buttonChooseProduct_Click(object sender, EventArgs e)
        {
            products.Add(selectedProduct);
            dataGridViewSelectedProducts.DataSource = products;
        }
        List<Product> products = new List<Product>();
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            allBusiness.Buy(products);
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
        }
    }
}
