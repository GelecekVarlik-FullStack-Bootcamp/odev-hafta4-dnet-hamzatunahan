using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Northwind.Entity.Models;

#nullable disable

namespace Northwind.Dal.Concrete.Entityframework.Context
{
    public partial class NORTHWINDContext : DbContext
    {
        //yontem 1
        /*  IConfiguration configuration;
        public NORTHWINDContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }*/

        public NORTHWINDContext()
        {

        }

       public NORTHWINDContext(DbContextOptions<NORTHWINDContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Talep> Talep { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
           // {
                //yontem 1
                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));
                //optionsBuilder.UseSqlServer("Server=DESKTOP-DCFBJJI;Database=NORTHWIND;Trusted_Connection=True;");
           // }
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
