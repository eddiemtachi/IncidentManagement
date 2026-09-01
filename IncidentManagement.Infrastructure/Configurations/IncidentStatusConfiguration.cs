using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentManagement.Infrastructure.Configurations
{
    public class IncidentStatusConfiguration : IEntityTypeConfiguration<IncidentStatus>
    {
        public void Configure(EntityTypeBuilder<IncidentStatus> builder)
        {
            builder.HasKey(s => s.StatusId);
            builder.Property(s => s.StatusName).IsRequired().HasMaxLength(50);
        }
    }
}
