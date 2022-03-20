using Assigment_WAD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assigment_WAD.Data
{
    public class MyIdentityDbContext : DbContext
    {
        public MyIdentityDbContext() : base("ConnectionString")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}