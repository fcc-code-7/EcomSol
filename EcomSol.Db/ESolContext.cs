using EcomSol.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomSol.Db
{
    public class ESolContext : DbContext
    {
        public ESolContext() : base("EcomSolDb")
        {
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
