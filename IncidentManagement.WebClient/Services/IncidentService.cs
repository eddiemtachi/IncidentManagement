using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;

namespace IncidentManagement.WebClient.Services
{
    public class IncidentService
    {
        private readonly IncidentApiClientRepository _repo;

        public IncidentService(IncidentApiClientRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<IncidentResponse> Incidents { get; private set; }
        public CreateIncidentRequest Incident { get; private set; }

        public async Task<IEnumerable<IncidentResponse>> FetchAllIncidentsAsync()
        {
            Incidents = await _repo.GetAllIncidentsAsync();
            return Incidents.OrderByDescending(i => i.CreatedAt); // Example business rule
        }
        //public List<Incident> Incidents { get; private set; } = new List<Incident>
        //{
        //    new Incident { IncidentId = 1, Title = "Network Outage", Description = "Main office network down", Status = "Open", Priority = "Low", LoggedBy = "Edward Mtachi", AssignedTo = "John Wick" },
        //    new Incident { IncidentId = 2, Title = "Email Issue", Description = "Emails not sending", Status = "In Progress", Priority = "High", LoggedBy = "Real Madrid", AssignedTo = "Edward Mtachi" },
        //    new Incident { IncidentId = 3, Title = "Printer Error", Description = "Printer not responding", Status = "Resolved", Priority = "Medium", LoggedBy = "John Wick", AssignedTo = "Real Madrid" }
        //};

        //public IEnumerable<Incident> GetIncidentsForUser(string username, string role)
        //{
        //    if (role == "Admin")
        //    {
        //        // Admin sees everything
        //        return Incidents;
        //    }
        //    else
        //    {
        //        // Normal user sees incidents they logged
        //        // Assigned user sees incidents assigned to them
        //        return Incidents.Where(i => i.Username == username);
        //    }
        //}

        public IncidentResponse? GetIncident(long id) =>
            Incidents.FirstOrDefault(i => i.IncidentId == id);

        public async Task AddIncident(CreateIncidentRequest newincident)
        {
            //incident.i.IncidentId = Incidents.Any() ? Incidents.Max(i => i.IncidentId) + 1 : 1;
            Incident = newincident;
            if (string.IsNullOrWhiteSpace(Incident.Title))
                throw new ArgumentException("Incident title is required");

            var incident = await _repo.CreateIncidentAsync(Incident);
            //return incident;
        }

        //public void UpdateIncident(Incident updatedIncident)
        //{
        //    var existing = GetIncident(updatedIncident.IncidentId);
        //    if (existing != null)
        //    {
        //        existing.Title = updatedIncident.Title;
        //        existing.Description = updatedIncident.Description;
        //        existing.Status = updatedIncident.Status;
        //        existing.AssignedTo = updatedIncident.AssignedTo;
        //    }
        //}

        //public void DeleteIncident(long id)
        //{
        //    var incident = GetIncident(id);
        //    if (incident != null)
        //    {
        //        Incidents.Remove(incident);
        //    }
        //}
    }
}
