using IncidentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Property = IncidentManagement.Domain.Entities.Property;

namespace IncidentManagement.Infrastructure.Data
{
    public class IncidentDbContext : DbContext
    {
        public IncidentDbContext(DbContextOptions<IncidentDbContext> options) 
            : base(options) { }

        public DbSet<Incident> Incidents { get; set; }
        public DbSet<IncidentCategory> IncidentCategories { get; set; }
        public DbSet<IncidentSeverity> IncidentSeverities { get; set; }
        public DbSet<IncidentStatus> IncidentStatuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IncidentDbContext).Assembly);
        }
    }
}
