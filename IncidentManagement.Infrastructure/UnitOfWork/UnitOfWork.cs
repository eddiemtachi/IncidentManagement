using IncidentManagement.Application.Interfaces;
using IncidentManagement.Application.UnitOfWork;
using IncidentManagement.Domain.Entities;
using IncidentManagement.Infrastructure.Data;
using IncidentManagement.Infrastructure.Repositories;

namespace IncidentManagement.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IncidentDbContext _context;
        public IIncidentRepository Incidents { get; }
        public IIncidentSeverityRepository IncidentSeverities { get; }
        public IIncidentStatusRepository IncidentStatuses { get; }
        public IPriorityRepository Priorities { get; }
        public IPropertyRepository Properties { get; }
        public IUserRepository Users { get; }

        public UnitOfWork(IncidentDbContext context)
        {
            _context = context;
            Incidents = new IncidentRepository(_context);
            IncidentSeverities = new IncidentSeverityRepository(_context);
            IncidentStatuses = new IncidentStatusRepository(_context);
            Priorities = new PriorityRepository(_context);
            Properties = new PropertyRepository(_context);
            Users = new UserRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
