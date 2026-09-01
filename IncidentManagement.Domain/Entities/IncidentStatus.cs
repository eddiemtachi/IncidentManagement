using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidentManagement.Domain.Entities
{
    public class IncidentStatus
    {
        public int StatusId { get; private set; }
        public string? StatusName { get; private set; }
    }
}
