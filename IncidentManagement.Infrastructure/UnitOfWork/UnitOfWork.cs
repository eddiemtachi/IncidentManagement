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
        public IPriorityRepository Priority { get; }
        public IPropertyRepository Properties { get; }
        public IUserRepository Users { get; }
        public IIncidentRoleRepository Roles { get; }

        public IIncidentCategoryRepository IncidentCategories { get; }

        public UnitOfWork(IncidentDbContext context)
        {
            _context = context;
            Incidents = new IncidentRepository(_context);
            IncidentSeverities = new IncidentSeverityRepository(_context);
            IncidentStatuses = new IncidentStatusRepository(_context);
            Priority = new PriorityRepository(_context);
            Properties = new PropertyRepository(_context);
            Users = new UserRepository(_context);
            Roles = new IncidentRoleRepository(_context);
            IncidentCategories = new IncidentCategoryRepository(_context);
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
