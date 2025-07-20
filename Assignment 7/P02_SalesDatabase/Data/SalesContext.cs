using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using P02_SalesDatabase.Model;

namespace P02_SalesDatabase.Data
{
    internal class SalesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesDatabase;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
