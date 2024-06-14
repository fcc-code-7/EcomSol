using EcomSol.Db;
using EcomSol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomSol.Services
{
    public class CategoryServices
    {
         ESolContext context = new ESolContext();
        public List<Category> getCategories()
        {
            return context.Categorys.ToList();
        }

        //ADD CATEGORIES
        public void AddCategories(Category category)
        {
           
                context.Categorys.Add(category);
                context.SaveChanges();
            
        }
        public Category FindCategory(int id)
        {
            var data= context.Categorys.Find(id);
            return (data);
            
        }
        public void UpdateCategory(Category category)
        {
            context.Entry(category).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            var category = context.Categorys.Find(id);
            context.Categorys.Remove(category);
            context.SaveChanges();
        }
    }
}
