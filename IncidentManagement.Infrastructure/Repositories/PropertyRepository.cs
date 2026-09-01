using IncidentManagement.Application.Interfaces;
using IncidentManagement.Domain.Entities;
using IncidentManagement.Infrastructure.Data;

namespace IncidentManagement.Infrastructure.Repositories
{
    public class PropertyRepository : EfRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(IncidentDbContext context)
            : base(context) { }

        public IncidentDbContext IncidentDbContext
        {
            get
            {
                return Context as IncidentDbContext;
            }
        }
    }
}
