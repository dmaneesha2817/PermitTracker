using PermitTracker.Core.Enums;

namespace PermitTracker.Core.Entities;

public class Inspection
{
    public int Id { get; set; }
    public int PermitId { get; set; }
    public InspectionResult Result { get; set; } = InspectionResult.Pending;
    public string? Notes { get; set; }
    public required string InspectorName { get; set; }
    public required DateTime ScheduledDate { get; set; }

    public Permit Permit { get; set; } = null!;
}