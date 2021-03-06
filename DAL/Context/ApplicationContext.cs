﻿using DAL.Entities;
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
        public DbSet<GuitarType> GuitarTypes { get; set; }
        public DbSet<Pegs> Pegs { get; set; }
        public DbSet<UpperDeck> UpperDecks { get; set; }
        public DbSet<LowerDeck> LowerDecks { get; set; }
        public DbSet<SidePanel> SidePanels { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<OverlayFingerboard> OverlayFingerboards { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ProducingCountry> ProducingCountries { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GuitarShopv2;Trusted_Connection=True;");
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
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.ProducerId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.NumberOfStrings)
                .WithMany(n => n.Products)
                .HasForeignKey(p => p.NumberOfStringsId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.NumberOfFrets)
               .WithMany(n => n.Products)
               .HasForeignKey(p => p.NumberOfFretsId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.GuitarType)
               .WithMany(t => t.Products)
               .HasForeignKey(p => p.GuitarTypeId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Pegs)
               .WithMany(p => p.Products)
               .HasForeignKey(p => p.PegsId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.UpperDeck)
               .WithMany(u => u.Products)
               .HasForeignKey(p => p.UpperDeckId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.LowerDeck)
               .WithMany(l => l.Products)
               .HasForeignKey(p => p.LowerDeckId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.SidePanel)
               .WithMany(s => s.Products)
               .HasForeignKey(p => p.SidePanelId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Features)
               .WithMany(f => f.Products)
               .HasForeignKey(p => p.FeaturesId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Color)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.ColorId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.OverlayFingerboard)
               .WithMany(o => o.Products)
               .HasForeignKey(p => p.OverlayFingerboardId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.Size)
               .WithMany(s => s.Products)
               .HasForeignKey(p => p.SizeId);

            modelBuilder.Entity<Product>()
               .HasOne(p => p.ProducingCountry)
               .WithMany(p => p.Products)
               .HasForeignKey(p => p.ProducingCountryId);
        }
    }
}
