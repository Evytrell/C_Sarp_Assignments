using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model
{
    public class MyDbContext : DbContext

    {
        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)   
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("Server=.\\MSSQLSERVER02;Database = OnlineShoppingAppDb;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        public DbSet<Buyers> Buyer { get; set; } 
        public DbSet<Invoice> Invoices { get; set; }
    }
}
