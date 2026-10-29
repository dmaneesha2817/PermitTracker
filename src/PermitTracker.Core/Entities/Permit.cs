using PermitTracker.Core.Enums;

namespace PermitTracker.Core.Entities;

public class Permit
{
    public int Id { get; set; }
    public required string PermitNumber { get; set; }
    public required PermitType Type { get; set; }
    public PermitStatus Status { get; set; } = PermitStatus.Submitted;
    public required string Address { get; set; }
    public required string Description { get; set; }
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    public int ApplicantId { get; set; }

    public Applicant Applicant { get; set; } = null!;
    public ICollection<Inspection> Inspections { get; set; } = [];
}
