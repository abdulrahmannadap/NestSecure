using Microsoft.EntityFrameworkCore;
using NestSecure.MaintenanceService.Entities;

namespace NestSecure.ComplaintService.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Maintenance> Maintenances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.ToTable("Maintenances");

                entity.HasKey(e => e.MaintenanceId);

                entity.Property(e => e.Month)
                      .IsRequired()
                      .HasMaxLength(20); // e.g., "April 2025"

                entity.Property(e => e.Amount)
                      .HasColumnType("decimal(18,2)")
                      .IsRequired();

                entity.Property(e => e.DueDate)
                      .IsRequired();

                entity.Property(e => e.PaidDate);

                entity.Property(e => e.Status)
                      .IsRequired()
                      .HasMaxLength(20); // e.g., Paid, Unpaid

                // Relationship with HouseOwner
                entity.HasOne(e => e.Owner)
                      .WithMany()
                      .HasForeignKey(e => e.OwnerId)
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
