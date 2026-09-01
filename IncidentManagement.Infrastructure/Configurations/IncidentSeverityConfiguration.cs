using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentManagement.Infrastructure.Configurations
{
    public class IncidentSeverityConfiguration : IEntityTypeConfiguration<IncidentSeverity>
    {
        public void Configure(EntityTypeBuilder<IncidentSeverity> builder)
        {
            builder.HasKey(s => s.SeverityId);
            builder.Property(s => s.SeverityName).IsRequired().HasMaxLength(50);
        }
    }
}
