using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SoChiTieuCaNhan.Configuration;

namespace SoChiTieuCaNhan.Models;

public partial class QL_ChiTieuContext : DbContext
{
    public QL_ChiTieuContext()
    {
    }

    public QL_ChiTieuContext(DbContextOptions<QL_ChiTieuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTieu> ChiTieus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connStr = ConfigurationHelper.Current.ConnectionStrings.DefaultConnection;
            if (string.IsNullOrWhiteSpace(connStr))
            {
                connStr = "Server=localhost;Database=QL_ChiTieu;Trusted_Connection=True;TrustServerCertificate=True;";
            }
            optionsBuilder.UseSqlServer(connStr);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTieu>(entity =>
        {
            entity.HasKey(e => e.MaCt).HasName("PK__ChiTieu__27258E7491263708");

            entity.ToTable("ChiTieu");

            entity.Property(e => e.MaCt).HasColumnName("MaCT");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
            entity.Property(e => e.LoaiChi).HasMaxLength(30);
            entity.Property(e => e.NoiDung).HasMaxLength(100);
            entity.Property(e => e.SoTien).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
