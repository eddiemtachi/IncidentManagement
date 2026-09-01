using IncidentManagement.Application.Interfaces;

namespace IncidentManagement.Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IIncidentRepository Incidents { get; }
        IIncidentSeverityRepository IncidentSeverities { get; }
        IIncidentStatusRepository IncidentStatuses { get; }
        IPriorityRepository Priorities { get; }
        IPropertyRepository Properties { get; }
        IUserRepository Users { get; }
        Task<int> CompleteAsync();
    }
}
