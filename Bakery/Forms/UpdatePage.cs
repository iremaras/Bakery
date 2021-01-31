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
    public partial class UpdatePage : Form
    {
        public UpdatePage()
        {
            InitializeComponent();
        }
        public AllBusiness allBusiness = new AllBusiness();
        public bakeryDbContext dbContext = new bakeryDbContext();
        private void UpdatePage_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
            comboBoxProducts.DataSource = allBusiness.GetProducts();
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
        }

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
        Product selectedProduct = null;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            selectedProduct.Name = textBoxProductName.Text;
            selectedProduct.Number = Convert.ToInt32(textBoxNumber.Text);
            selectedProduct.ProducedDay = Convert.ToDateTime(textBoxProducedDate.Text);
            selectedProduct.Ingridients = textBoxIngridients.Text;
            allBusiness.Update(selectedProduct);
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
        }
    }
}
