using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


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



        public virtual DbSet<CustomerFirstLast> CustomerFirstLasts { get; set; } = null!;
        public virtual DbSet<MonthlyTopItemSale> MonthlyTopItemSales { get; set; } = null!;
        public virtual DbSet<PriceMinMax> PriceMinMaxes { get; set; } = null!;
        public virtual DbSet<Top10MonthlyCust> Top10MonthlyCusts { get; set; } = null!;
        public virtual DbSet<Top5MonthlySalesItem> Top5MonthlySalesItems { get; set; } = null!;
        public virtual DbSet<YearlyTran> YearlyTrans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string strConn = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\ASUS\\source\\repos\\WanluShopWebAPI\\WanluShopWebAPI\\DB\\WanluClothDB.mdf; Integrated Security = True; Connect Timeout = 30";
                optionsBuilder.UseSqlServer(strConn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

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

            modelBuilder.Entity<PriceMinMax>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PriceMinMax");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");
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

                entity.Property(e => e.OutletTown)
                    .HasMaxLength(50)
                    .HasColumnName("outletTown");
            });

            modelBuilder.Entity<Top5MonthlySalesItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Top5MonthlySalesItem");

                entity.Property(e => e.Diff).HasColumnName("diff");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");
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
