using Microsoft.EntityFrameworkCore;
using NestSecure.AuthService.Entities;

namespace NestSecure.AuthService.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasKey(e => e.RoleId);
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(50);

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Username)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Email)
                      .HasMaxLength(100);

                entity.Property(e => e.PasswordHash)
                      .IsRequired();

                entity.Property(e => e.IsActive)
                      .HasDefaultValue(true);

                entity.HasOne(e => e.Role)
                      .WithMany()
                      .HasForeignKey(e => e.RoleId)
                      .OnDelete(DeleteBehavior.Restrict);

                // Optional: BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.CreatedDate);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

        }

    }
}
