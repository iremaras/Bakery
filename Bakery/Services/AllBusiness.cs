using Bakery.Data;
using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Services
{
    public class AllBusiness
    {
        bakeryDbContext dbContext = new bakeryDbContext();

        public List<Product> GetProducts()
        {

            return dbContext.Products.ToList();
        }

        public List<Category> GetCatergories()
        {
            return dbContext.Categories.ToList();
        }

        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Remove(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }
        public void Update(Product product)
        {
            dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public List<Product> GetProductsByCategory(Category category)
        {
            return category.Products.ToList();
        }

        public Product GetProductsById(int Id)
        {
            return dbContext.Products.Find(Id);
        }

        public void Buy(List<Product> products)
        {
            foreach (var item in products)
            {
                item.Number -= 1;
                if (item.Number == 0)
                {
                    Remove(item);
                }
            }
            dbContext.SaveChanges();
        }

        public void AddCategory(string category)
        {
            dbContext.Categories.Add(new Category { CategoryName = category });
            dbContext.SaveChanges();
        }

        public string RemoveCategory(Category category)
        {
            if (category.Products!=null)
            {
                return "Bu kategoride ürün bulunuyor!";
            }
            else
            {
                dbContext.Remove(category);
                dbContext.SaveChanges();
                return "Başarılı";
            } 
        }

        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.Find(id);
        }
    }
}
