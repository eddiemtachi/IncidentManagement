using IncidentManagement.Application.Interfaces;

namespace IncidentManagement.Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IIncidentRepository Incidents { get; }
        IIncidentSeverityRepository IncidentSeverities { get; }
        IIncidentStatusRepository IncidentStatuses { get; }
        IIncidentRoleRepository Roles { get; }
        IPriorityRepository Priority { get; }
        IPropertyRepository Properties { get; }
        IUserRepository Users { get; }
        IIncidentCategoryRepository IncidentCategories { get; }

        Task<int> CompleteAsync();
    }
}
