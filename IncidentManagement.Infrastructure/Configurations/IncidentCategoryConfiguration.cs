using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentManagement.Infrastructure.Configurations
{
    public class IncidentCategoryConfiguration : IEntityTypeConfiguration<IncidentCategory>
    {
        public void Configure(EntityTypeBuilder<IncidentCategory> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName).IsRequired().HasMaxLength(100);
        }
    }
}
