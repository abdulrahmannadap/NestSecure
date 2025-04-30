using Microsoft.EntityFrameworkCore;
using NestSecure.VisitorService.Entities;

namespace NestSecure.VisitorService.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Visitor> Visitors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.ToTable("Visitors");

                entity.HasKey(e => e.VisitorId);

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Phone)
                      .HasMaxLength(20);

                entity.Property(e => e.VisitTime)
                      .IsRequired();

                entity.Property(e => e.ExitTime);

                entity.Property(e => e.Purpose)
                      .HasMaxLength(200);

                entity.Property(e => e.FlatNumber)
                      .HasMaxLength(20);

                entity.Property(e => e.IsPreApproved)
                      .HasDefaultValue(false);

                // Relationships
                entity.HasOne(e => e.ApprovedByOwner)
                      .WithMany()
                      .HasForeignKey(e => e.ApprovedByOwnerId)
                      .OnDelete(DeleteBehavior.Restrict); // Optional, based on your logic

                entity.HasOne(e => e.Guard)
                      .WithMany()
                      .HasForeignKey(e => e.GuardId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.Society)
                      .WithMany()
                      .HasForeignKey(e => e.SocietyId)
                      .OnDelete(DeleteBehavior.Cascade);

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
