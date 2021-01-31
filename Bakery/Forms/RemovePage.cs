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
    public partial class RemovePage : Form
    {
        public RemovePage()
        {
            InitializeComponent();
        }
        AllBusiness allBusiness = new AllBusiness();
        bakeryDbContext dbContext = new bakeryDbContext();
        private void RemovePage_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
            comboBoxProducts.DataSource = allBusiness.GetProducts();
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
        }

        Product selectedProduct = null;
        private void comboBoxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxProducts.SelectedValue;
            Product product = allBusiness.GetProductsById(selectedProductId);
            textBoxProductName.Text = product.Name;
            textBoxIngridients.Text = product.Ingridients;
            textBoxNumber.Text = product.Number.ToString();
            textBoxProducedDate.Text = product.ProducedDay.ToString();
            selectedProduct = product;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            allBusiness.Remove(selectedProduct);
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
        }
    }
}
