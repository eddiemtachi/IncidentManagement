using IncidentManagement.Application.Interfaces;
using IncidentManagement.Domain.Entities;
using IncidentManagement.Infrastructure.Data;

namespace IncidentManagement.Infrastructure.Repositories
{
    public class IncidentStatusRepository : EfRepository<IncidentStatus>, IIncidentStatusRepository
    {
        public IncidentStatusRepository(IncidentDbContext context)
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
