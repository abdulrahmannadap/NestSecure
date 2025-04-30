using Microsoft.EntityFrameworkCore;
using NestSecure.ComplaintService.Entities;

namespace NestSecure.ComplaintService.Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Complaint> Complaints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Complaint>(entity =>
            {
                entity.ToTable("Complaints");

                entity.HasKey(e => e.ComplaintId);

                entity.Property(e => e.Title)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.Description)
                      .HasMaxLength(1000);

                entity.Property(e => e.Status)
                      .IsRequired()
                      .HasMaxLength(20); // e.g., Open, In Progress, Closed

                entity.Property(e => e.CreatedDate)
                      .IsRequired();

                // Relationships
                entity.HasOne(e => e.RaisedByOwner)
                      .WithMany()
                      .HasForeignKey(e => e.RaisedByOwnerId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.AssignedToSecretary)
                      .WithMany()
                      .HasForeignKey(e => e.AssignedToSecretaryId)
                      .OnDelete(DeleteBehavior.Restrict);

                // BaseEntity properties
                entity.Property(e => e.CreatedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedBy).HasMaxLength(100);
                entity.Property(e => e.DeletedDate);
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });


        }

    }
}
