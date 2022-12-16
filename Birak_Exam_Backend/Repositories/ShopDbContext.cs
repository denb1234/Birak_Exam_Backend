using Birak_Exam_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Birak_Exam_Backend.Repositories
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Clothes> clothesItems = new List<Clothes>();
            clothesItems.Add(new Clothes { Id = 1, Name = "wegwegweg", Price = 450.50, Brand = "gergerm", Date = new DateTime(2022, 9, 21), Size = 37.5, Model = "fewfwe", Quantity = 5, IsBought = true });
            clothesItems.Add(new Clothes { Id = 2, Name = "gerg", Price = 750.50, Brand = "rthrt", Date = new DateTime(2022, 8, 13), Size = 40.5, Model = "h65h65", Quantity = 7, IsBought = false });

            foreach(Clothes clothes in clothesItems)
            {
                if (!clothes.IsBought)
                {
                    var diff = DateTime.Today - clothes.Date;
                    int monthDifference = diff.Days / 30;

                    if (monthDifference > 0)
                    {
                        clothes.Discount = (int)(Math.Floor(((double)monthDifference) / 2) * 10);
                    }
                }
            }

            modelBuilder.Entity<Clothes>()
               .HasData(
                   clothesItems[0],
                   clothesItems[1]                 
               );         

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Clothes> ClothesItems { get; set; }
    }
}
