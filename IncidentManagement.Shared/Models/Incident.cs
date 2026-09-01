using System;
using System.ComponentModel.DataAnnotations;

public class Incident
{
    [Key]
    public int IncidentId { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Status is required")]
    [RegularExpression("Open|In Progress|Resolved|Closed",
        ErrorMessage = "Status must be one of: Open, In Progress, Resolved, Closed")]
    public string Status { get; set; } = "Open";

    [Required(ErrorMessage = "Priority is required")]
    [RegularExpression("Low|Medium|High|Critical",
        ErrorMessage = "Priority must be one of: Low, Medium, High, Critical")]
    public string Priority { get; set; } = "Medium";

    [Required(ErrorMessage = "Assigned To is required")]
    [StringLength(50, ErrorMessage = "Assigned To cannot exceed 50 characters")]
    public string AssignedTo { get; set; } = string.Empty;

    [Required]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public string LoggedBy { get; set; } = string.Empty;
    //public string AssignedTo { get; set; } = string.Empty;
}
