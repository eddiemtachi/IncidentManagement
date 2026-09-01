namespace IncidentManagement.Application.Dtos.Responses
{
    public record IncidentResponse(
        int IncidentId,
        string Title,
        string Description,
        string Username,
        string CategoryName,
        string SeverityName,
        string StatusName,
        string PriorityName,
        string ReporterName,
        string PropertyName,
        DateTime CreatedAt,
        DateTime UpdatedAt
    );
}
