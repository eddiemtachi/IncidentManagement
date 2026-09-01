using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentManagement.Infrastructure.Configurations
{
    public class IncidentConfiguration : IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> builder)
        {
            builder.HasKey(i => i.IncidentId);

            builder.Property(i => i.Title).IsRequired().HasMaxLength(200);
            builder.Property(i => i.Description).HasMaxLength(1000);

            builder.HasOne(i => i.Category)
                .WithMany()
                .HasForeignKey(i => i.CategoryId);

            builder.HasOne(i => i.Severity)
                .WithMany()
                .HasForeignKey(i => i.SeverityId);

            builder.HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);

            builder.HasOne(i => i.Priority)
                .WithMany()
                .HasForeignKey(i => i.PriorityId);

            builder.HasOne(i => i.User)
                .WithMany()
                .HasForeignKey(i => i.UserId);

            builder.HasOne(i => i.Property)
                .WithMany()
                .HasForeignKey(i => i.PropertyId);
        }
    }
}
