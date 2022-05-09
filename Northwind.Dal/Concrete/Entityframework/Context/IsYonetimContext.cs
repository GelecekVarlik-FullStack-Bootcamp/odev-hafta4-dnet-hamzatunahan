using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Northwind.Entity.Models;

#nullable disable

namespace Northwind.Dal.Concrete.Entityframework.Context
{
    public partial class IsYonetimContext : DbContext
    {
        public IsYonetimContext()
        {
        }

        public IsYonetimContext(DbContextOptions<IsYonetimContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Talep> Taleps { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            

            modelBuilder.Entity<Talep>(entity =>
            {
                entity.ToTable("Talep");

                entity.Property(e => e.BaslamaTarihi).HasMaxLength(50);

                entity.Property(e => e.DepartmanKonusu).HasMaxLength(50);

                entity.Property(e => e.Icerik).HasMaxLength(50);

                entity.Property(e => e.OncelikDurumu).HasMaxLength(50);

                entity.Property(e => e.TalepBasligi).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TelNo).HasMaxLength(40);

                entity.Property(e => e.UserCode).HasMaxLength(50);

                entity.Property(e => e.UserLastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserMail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserYetki).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
