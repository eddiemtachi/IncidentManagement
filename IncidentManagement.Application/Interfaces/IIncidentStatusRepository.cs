using IncidentManagement.Application.GenericInterfaces;
using IncidentManagement.Domain.Entities;

namespace IncidentManagement.Application.Interfaces
{
    public interface IIncidentStatusRepository : IRepository<IncidentStatus>
    {
    }
}
