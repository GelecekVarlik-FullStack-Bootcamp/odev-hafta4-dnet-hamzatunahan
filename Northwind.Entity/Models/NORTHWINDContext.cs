using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class NORTHWINDContext : DbContext
    {
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
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DCFBJJI;Database=IsYonetim;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");


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
