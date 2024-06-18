using EcomSol.Db;
using EcomSol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomSol.Services
{
    public class ProductServices
    {
         ESolContext context = new ESolContext();
        public List<Product> getProducts()
        {
            using (context)
            {
                    return context.Products.ToList();
            }
        }

        //ADD CATEGORIES
        public void AddProducts(Product product)
        {
           
                context.Products.Add(product);
                context.SaveChanges();
            
        }
        public Product FindProduct(int id)
        {
            var data= context.Products.Find(id);
            return (data);
            
        }
        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
