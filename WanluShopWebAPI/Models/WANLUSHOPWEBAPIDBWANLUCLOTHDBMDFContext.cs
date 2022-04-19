using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WanluShopWebAPI.Models
{
    public partial class WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext : DbContext
    {
        public WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext()
        {
        }

        public WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext(DbContextOptions<WANLUSHOPWEBAPIDBWANLUCLOTHDBMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerFirstLast> CustomerFirstLasts { get; set; } = null!;
        public virtual DbSet<FirstLastCustId> FirstLastCustIds { get; set; } = null!;
        public virtual DbSet<MonthlyTopItemSale> MonthlyTopItemSales { get; set; } = null!;
        public virtual DbSet<Outlet> Outlets { get; set; } = null!;
        public virtual DbSet<PriceMinMax> PriceMinMaxes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Top10Customer> Top10Customers { get; set; } = null!;
        public virtual DbSet<Top10MonthlyCust> Top10MonthlyCusts { get; set; } = null!;
        public virtual DbSet<Top5MonthlySalesItem> Top5MonthlySalesItems { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<YearlyTran> YearlyTrans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\source\\repos\\WanluShopWebAPI\\WanluShopWebAPI\\DB\\WanluClothDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customerID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerName)
                    .HasColumnType("text")
                    .HasColumnName("customerName");

                entity.Property(e => e.OutletId).HasColumnName("outletID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerFirstLast>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CustomerFirstLast");

                entity.Property(e => e.CustomerName)
                    .HasColumnType("text")
                    .HasColumnName("customerName");

                entity.Property(e => e.OutletTown)
                    .HasMaxLength(50)
                    .HasColumnName("outletTown");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<FirstLastCustId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_FirstLastCustID");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.OutletId).HasColumnName("outletID");
            });

            modelBuilder.Entity<MonthlyTopItemSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MonthlyTopItemSales");

                entity.Property(e => e.Month)
                    .HasMaxLength(10)
                    .HasColumnName("month")
                    .IsFixedLength();

                entity.Property(e => e.OutletTown)
                    .HasMaxLength(50)
                    .HasColumnName("outletTown");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .HasColumnName("year")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Outlet>(entity =>
            {
                entity.ToTable("Outlet");

                entity.Property(e => e.OutletId)
                    .HasColumnName("outletID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OutletName)
                    .HasMaxLength(50)
                    .HasColumnName("outletName");

                entity.Property(e => e.OutletTown)
                    .HasMaxLength(50)
                    .HasColumnName("outletTown");
            });

            modelBuilder.Entity<PriceMinMax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PriceMinMax");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");
            });

            modelBuilder.Entity<Top10Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Top10Customer");

                entity.Property(e => e.Comm).HasColumnName("comm");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.Month)
                    .HasMaxLength(10)
                    .HasColumnName("month")
                    .IsFixedLength();

                entity.Property(e => e.OutletTown)
                    .HasMaxLength(50)
                    .HasColumnName("outletTown");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .HasColumnName("year")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Top10MonthlyCust>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Top10MonthlyCust");

                entity.Property(e => e.Comm).HasColumnName("comm");

                entity.Property(e => e.CustomerName)
                    .HasColumnType("text")
                    .HasColumnName("customerName");

                entity.Property(e => e.Month)
                    .HasMaxLength(10)
                    .HasColumnName("month")
                    .IsFixedLength();

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .HasColumnName("year")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Top5MonthlySalesItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Top5MonthlySalesItem");

                entity.Property(e => e.Diff).HasColumnName("diff");

                entity.Property(e => e.ProdId)
                    .HasMaxLength(50)
                    .HasColumnName("ProdID");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("PK__Transact__9E5DDB1C73367A60");

                entity.ToTable("Transaction");

                entity.Property(e => e.TransId)
                    .HasColumnName("TransID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .HasColumnName("date")
                    .IsFixedLength();

                entity.Property(e => e.Month)
                    .HasMaxLength(10)
                    .HasColumnName("month")
                    .IsFixedLength();

                entity.Property(e => e.OutletId)
                    .HasMaxLength(50)
                    .HasColumnName("outletID");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("productID");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .HasColumnName("year")
                    .IsFixedLength();
            });

            modelBuilder.Entity<YearlyTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("YearlyTrans");

                entity.Property(e => e.OutletTown)
                    .HasMaxLength(50)
                    .HasColumnName("outletTown");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .HasColumnName("year")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
