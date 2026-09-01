using IncidentManagement.Application.GenericInterfaces;
using IncidentManagement.Domain.Entities;

namespace IncidentManagement.Application.Interfaces
{
    public interface IIncidentRepository : IRepository<Incident>
    {
        Task<IEnumerable<Incident>> GetAllIncidentsAsync();
        Task<IEnumerable<Incident>> GetByPropertyAsync(int propertyId);
        Task<IEnumerable<Incident>> GetByReporterAsync(int reporterId);
    }
}
