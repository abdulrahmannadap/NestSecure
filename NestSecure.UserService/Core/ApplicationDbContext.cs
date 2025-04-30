using Microsoft.EntityFrameworkCore;
using NestSecure.UserService.Entities;

namespace NestSecure.UserService.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Society> Societies { get; set; }
        public virtual DbSet<HouseOwner> HouseOwners { get; set; }
        public virtual DbSet<SecurityGuard> SecurityGuards { get; set; }
        public virtual DbSet<Secretary> Secretaries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Society>(entity =>
            {
                entity.ToTable("Societies");

                entity.HasKey(e => e.SocietyId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.City).HasMaxLength(100);
                entity.Property(e => e.Pincode).HasMaxLength(10);
                entity.Property(e => e.CreatedDate);

                // BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<HouseOwner>(entity =>
            {
                entity.ToTable("HouseOwners");

                entity.HasKey(e => e.OwnerId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.FlatNumber).HasMaxLength(20);
                entity.Property(e => e.PasswordHash).IsRequired();
                entity.Property(e => e.IsApproved).HasDefaultValue(false);
                entity.Property(e => e.CreatedDate);

                entity.HasOne(e => e.Society)
                      .WithMany()
                      .HasForeignKey(e => e.SocietyId);

                // BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SecurityGuard>(entity =>
            {
                entity.ToTable("SecurityGuards");

                entity.HasKey(e => e.GuardId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.ShiftTime).HasMaxLength(50);
                entity.Property(e => e.PasswordHash).IsRequired();

                entity.HasOne(e => e.Society)
                      .WithMany()
                      .HasForeignKey(e => e.SocietyId);

                // BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.CreatedDate);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<Secretary>(entity =>
            {
                entity.ToTable("Secretaries");

                entity.HasKey(e => e.SecretaryId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.Property(e => e.PasswordHash).IsRequired();

                entity.HasOne(e => e.Society)
                      .WithMany()
                      .HasForeignKey(e => e.SocietyId);

                // BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.CreatedDate);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

        }

    }
}
