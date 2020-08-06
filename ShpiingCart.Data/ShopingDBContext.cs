using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShpiingCart.Data.Models
{
    public partial class ShopingDBContext : DbContext
    {
        public ShopingDBContext()
        {
        }

        public ShopingDBContext(DbContextOptions<ShopingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsInfo> ProductsInfo { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6CDCB718BAC");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsInfo>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Products__CA1EE04CDDDCAC8F");

                entity.Property(e => e.Sno).HasColumnName("SNo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsInfo)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductsI__Produ__25869641");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__UserInfo__CA1EE04C0F67A354");

                entity.Property(e => e.Sno).HasColumnName("SNo");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
