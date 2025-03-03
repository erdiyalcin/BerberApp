using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BerberApp.Models;

public partial class DbberberContext : DbContext
{
    public DbberberContext()
    {
    }

    public DbberberContext(DbContextOptions<DbberberContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kullanici> Kullanicis { get; set; }

    public virtual DbSet<Yetki> Yetkis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DELL\\SQLEXPRESS;Database=DBBerber;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kullanici>(entity =>
        {
            entity.ToTable("Kullanici");

            entity.Property(e => e.KullaniciId).HasColumnName("kullaniciID");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("ad");
            entity.Property(e => e.Eposta)
                .HasMaxLength(50)
                .HasColumnName("eposta");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("sifre");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .HasColumnName("soyad");
            entity.Property(e => e.YetkiId).HasColumnName("yetkiID");

            entity.HasOne(d => d.Yetki).WithMany(p => p.Kullanicis)
                .HasForeignKey(d => d.YetkiId)
                .HasConstraintName("FK_Kullanici_Yetki");
        });

        modelBuilder.Entity<Yetki>(entity =>
        {
            entity.ToTable("Yetki");

            entity.Property(e => e.YetkiId).HasColumnName("yetkiID");
            entity.Property(e => e.Ad)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ad");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
