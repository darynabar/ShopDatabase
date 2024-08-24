using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabase2
{
    public class ShopDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"workstation id=ShopDatabase2.mssql.somee.com;Initial Catalog = Shop;packet size=4096;user id=Daryna_SQLLogin_1;pwd=7j9wq4kgrr;data source=ShopDatabase2.mssql.somee.com;persist security info=False;initial catalog=ShopDatabase2;TrustServerCertificate=True");
        }

    }

}
