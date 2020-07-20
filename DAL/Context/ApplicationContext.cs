using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<NumberOfStrings> NumberOfStrings { get; set; }
        public DbSet<NumberOfFrets> NumberOfFrets { get; set; }
        public DbSet<TypeOfCorps> TypeOfCorps { get; set; }
        public DbSet<Pegs> Pegs { get; set; }
        public DbSet<UpperDeck> UpperDecks { get; set; }
        public DbSet<LowerDeck> LowerDecks { get; set; }
        public DbSet<SidePanel> SidePanels { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<NumberOfFrets> Colors { get; set; }
        public DbSet<OverlayFingerboard> OverlayFingerboards { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ProducingCountry> ProducingCountries { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GuitarShop;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasOne(u => u.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);       
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Producer)
                .WithMany(p => p.Products);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.NumberOfStrings)
                .WithMany(n => n.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.NumberOfFrets)
               .WithMany((System.Linq.Expressions.Expression<Func<NumberOfFrets, IEnumerable<Product>>>)(n => (IEnumerable<Product>)n.Products));

            modelBuilder.Entity<Product>()
               .HasOne(p => p.TypeOfCorps)
               .WithMany(t => t.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Pegs)
               .WithMany(p => p.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.UpperDeck)
               .WithMany(u => u.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.LowerDeck)
               .WithMany(l => l.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.SidePanel)
               .WithMany(s => s.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Features)
               .WithMany(f => f.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Color)
               .WithMany((System.Linq.Expressions.Expression<Func<NumberOfFrets, IEnumerable<Product>>>)(c => (IEnumerable<Product>)c.Products));

            modelBuilder.Entity<Product>()
               .HasOne(p => p.OverlayFingerboard)
               .WithMany(o => o.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Size)
               .WithMany(s => s.Products);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.ProducingCountry)
               .WithMany(p => p.Products);
        }
    }
}
