namespace Assigment_WAD.Migrations
{
    using Assigment_WAD.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assigment_WAD.Data.MyIdentityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assigment_WAD.Data.MyIdentityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var product = new List<Product>{
                new Product{Id = 1,Name = "Aó sơ mi ngắn tay",Prices=250000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=1,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/so-mi-dai-tay/als25202/ao-so-mi-nam-aristino-ALS25202-04x500x500x4.jpg"},
                new Product{Id = 2,Name = "Aó Polo",Prices=300000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=1,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/so-mi-ngan-tay/ass101s1/ao-so-mi-aristino-ASS101S1-02x500x500x4.jpg"},
                new Product{Id = 3,Name = "Quần âu nam",Prices=200000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=2,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/quan-au/atr00201/quan-au-nam-aristino-ATR00201-06x500x500x4.jpg"},
                new Product{Id = 4 ,Name = "Quần kaki nam",Prices=280000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=2,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/quan-kaki/akkr02/quan-kaki-nam-aristino-AKKR02-14x500x500x4.jpg"},
                new Product{Id = 5,Name = "Aó khoác gió",Prices=400000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=3,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/ao-khoac/ajk002w9/ao-khoac-nam-aristino-AJK002W9-04x500x500x4.jpg"},
                new Product{Id = 6,Name = "Aó phao",Prices=500000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=3,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/ao-khoac/ajk026w1/ao-khoac-nam-AJK026W1x500x500x4.jpg"},
                new Product{Id = 7,Name = "Aó phông",Prices=150000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=3,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/ao-tshirt/ats022s1/ao-thun-nam-aristino-ATS022S1-01x500x500x4.jpg"},
                new Product{Id = 8,Name = "Quần đùi",Prices=120000,Description="Aó sơ mi được sản xuất tại Việt Nam", Detail="Aó sơ mi",CategoryID=2,Thumbnail = "https://aristino.com/Data/ResizeImage/images/product/quan-short/aso002s2/quan-short-nam-aristino-ASO002S2-01x500x500x4.jpg"}
            };
            product.ForEach(s => context.Products.AddOrUpdate(s));
            var category = new List<Category>
            {
                new Category{ID=1,Name="Aó"},
                new Category{ID=2,Name="Quần"},
                new Category{ID=3,Name="Aó khoác"}
            };
            category.ForEach(s => context.Categories.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
