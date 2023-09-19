using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VittaFormsApp.Models;

namespace VittaFormsApp.Data;

public partial class VittaDbContext : DbContext
{
    public VittaDbContext()
    {
    }

    public VittaDbContext(DbContextOptions<VittaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<ReceiptMoney> ReceiptMoneys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-17BKQTC\\DESKTOPNAUMENKO;Initial Catalog=VittaDb;Persist Security Info=True;Encrypt=False;TrustServerCertificate=False;User ID=sa;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order");

            entity.Property(e => e.IdOrder).HasColumnName("Id_Order");
            entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.IdPayment);

            entity.ToTable("Payment", tb => tb.HasTrigger("UpdatePayment"));

            entity.Property(e => e.IdPayment).HasColumnName("Id_Payment");
            entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.OrderId).HasColumnName("Order_Id");
            entity.Property(e => e.ReceiptMoneyId).HasColumnName("ReceiptMoney_Id");
        });

        modelBuilder.Entity<ReceiptMoney>(entity =>
        {
            entity.HasKey(e => e.IdReceiptMoney);

            entity.ToTable("ReceiptMoney");

            entity.Property(e => e.IdReceiptMoney).HasColumnName("Id_ReceiptMoney");
            entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Balance).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
