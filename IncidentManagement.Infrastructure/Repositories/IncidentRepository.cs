using IncidentManagement.Application.Interfaces;
using IncidentManagement.Domain.Entities;
using IncidentManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IncidentManagement.Infrastructure.Repositories
{
    public class IncidentRepository : EfRepository<Incident>, IIncidentRepository
    {
        public IncidentRepository(IncidentDbContext context)
            : base(context) { }

        public IncidentDbContext IncidentDbContext
        {
            get
            {
                return Context as IncidentDbContext;
            }
        }

        public async Task<IEnumerable<Incident>> GetAllIncidentsAsync()
        {
            return await IncidentDbContext.Incidents
                .Include(i => i.Category)
                .Include(i => i.Severity)
                .Include(i => i.Status)
                .Include(i => i.Priority)
                .Include(i => i.User)
                .Include(i => i.Property)
                //.Skip((pageIndex - 1) * pageSize)
                //.Take(pageSize)
                .ToListAsync();
        }

        public Task<IEnumerable<Incident>> GetByPropertyAsync(int propertyId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Incident>> GetByReporterAsync(int reporterId)
        {
            throw new NotImplementedException();
        }
    }
}
