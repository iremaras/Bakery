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

namespace Bakery.Forms
{
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        AllBusiness allBusiness = new AllBusiness();
        bakeryDbContext dbContext = new bakeryDbContext();
        private void CategoryPage_Load(object sender, EventArgs e)
        {
            dataGridViewCategories.DataSource = allBusiness.GetCatergories();
            comboBoxCategories.DataSource = allBusiness.GetCatergories();
            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "Id";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            allBusiness.AddCategory(textBoxCategory.Text);
            dataGridViewCategories.DataSource = allBusiness.GetCatergories();
            comboBoxCategories.DataSource = allBusiness.GetCatergories();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show( allBusiness.RemoveCategory(selectedCategory));
            dataGridViewCategories.DataSource = allBusiness.GetCatergories();
            comboBoxCategories.DataSource = allBusiness.GetCatergories();
        }

        Category selectedCategory = null;
        private void comboBoxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category category = allBusiness.GetCategoryById((int)comboBoxCategories.SelectedValue);
            selectedCategory = category;
        }
    }
}
