namespace PermitTracker.Core.Entities;

public class Applicant
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public string? PhoneNumber { get; set; }

    public ICollection<Permit> Permits { get; set; } = [];
}
