using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentManagement.Infrastructure.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(p => p.PropertyId);
            builder.Property(p => p.PropertyName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.AddressLine1).HasMaxLength(200);
            builder.Property(p => p.AddressLine2).HasMaxLength(200);
            builder.Property(p => p.City).HasMaxLength(100);
            builder.Property(p => p.Province).HasMaxLength(100);
            builder.Property(p => p.PostalCode).HasMaxLength(20);
        }
    }
}
