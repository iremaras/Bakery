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
    public partial class AddPage : Form
    {
        public AddPage()
        {
            InitializeComponent();
        }
        AllBusiness allBusiness = new AllBusiness();
        bakeryDbContext dbContext = new bakeryDbContext();
        private void AddPage_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
            comboBoxCategories.DataSource = allBusiness.GetCatergories();
            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "Id";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBoxProductName.Text;
            product.Number = Convert.ToInt32(textBoxNumber.Text);
            product.ProducedDay = Convert.ToDateTime(textBoxProducedDate.Text);
            product.Ingridients = textBoxIngridients.Text;
            product.CategoryId = selectedCategory.Id;
            allBusiness.Add(product);
            dataGridViewProducts.DataSource = allBusiness.GetProducts();
            
        }

        Category selectedCategory = null;
        private void comboBoxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category category = new Category();
            category = allBusiness.GetCategoryById((int)comboBoxCategories.SelectedValue);
            selectedCategory = category;
        }
    }
}
