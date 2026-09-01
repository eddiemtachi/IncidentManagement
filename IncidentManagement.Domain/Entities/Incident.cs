using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidentManagement.Domain.Entities
{    
    public class Incident
    {
        public int IncidentId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public int CategoryId { get; private set; }
        public IncidentCategory Category { get; private set; }

        public int SeverityId { get; private set; }
        public IncidentSeverity Severity { get; private set; }

        public int StatusId { get; private set; }
        public IncidentStatus Status { get; private set; }

        public int PriorityId { get; private set; }
        public Priority Priority { get; private set; }

        public int UserId { get; private set; }
        public User User { get; private set; }

        public int PropertyId { get; private set; }
        public Property Property { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Incident(string title, string description, int categoryId, int severityId,
                        int statusId, int priorityId, int userId, int propertyId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
            SeverityId = severityId;
            StatusId = statusId;
            PriorityId = priorityId;
            UserId = userId;
            PropertyId = propertyId;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateStatus(int newStatusId)
        {
            StatusId = newStatusId;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
