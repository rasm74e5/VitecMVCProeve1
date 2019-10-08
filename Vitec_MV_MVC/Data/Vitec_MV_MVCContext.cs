using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vitec_MV_MVC.Models
{
    public class Vitec_MV_MVCContext : DbContext
    {
        public Vitec_MV_MVCContext (DbContextOptions<Vitec_MV_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");

        }

    }
}
