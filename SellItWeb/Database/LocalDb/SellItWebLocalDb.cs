using SellItCore.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SellItWeb.Database.LocalDb
{
    public class SellItWebLocalDb : DbContext
    {
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        public SellItWebLocalDb()
        {
            if (this.Database.CreateIfNotExists())
            {
                LoadBaseFixtures();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyer>().HasMany(x => x.Orders);
            modelBuilder.Entity<Seller>().HasMany(x => x.Orders);
            modelBuilder.Entity<Product>().HasRequired(x => x.ProductType);
            modelBuilder.Entity<ProductType>().HasMany(x => x.Categories);

            base.OnModelCreating(modelBuilder);
        }

        private void LoadBaseFixtures()
        {
            //TODO: code me
        }
    }
}