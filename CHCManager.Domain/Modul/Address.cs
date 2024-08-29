namespace CHCManager.Domain.Modul;

public class Address
{
    // Address Properties:
    public int Id { get; set; }                        // Unique identifier for the address

    public string Country { get; set; } = string.Empty;  // Country where the address is located
    public string City { get; set; } = string.Empty;     // City where the address is located
    public int StreetNumber { get; set; }                // Number of the street in the address
    public string BuildingName { get; set; } = string.Empty; // Name of the building  at the address

    // Foreign keys:
    public int PatientId { get; set; }            // Foreign key referencing a Patient
    public int ClinicianId { get; set; }          // Foreign key referencing a Clinician 
}
