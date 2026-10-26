using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentManagement.Infrastructure.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Roles>
    {   
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasKey(p => p.RoleId);
            builder.Property(p => p.RoleName).IsRequired().HasMaxLength(50);
        }
    }
}
