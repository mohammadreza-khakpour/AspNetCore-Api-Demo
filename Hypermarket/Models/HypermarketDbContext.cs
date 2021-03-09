using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypermarket.Models
{
    public class HypermarketDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=aspNetCoreDemo;trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<GoodCategory> GoodCategories { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<GoodEntry> GoodEntries { get; set; }
        public DbSet<SalesFactor> SalesFactors { get; set; }
    }
}
