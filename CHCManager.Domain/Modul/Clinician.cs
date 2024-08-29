using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul;

public class Clinician
{
    // Clinician Properties:

    // Unique identifier for the clinician
    public int Id { get; set; }

    // First name of the clinician
    public string FirstName { get; set; } = string.Empty;

    // Last name of the clinician
    public string LastName { get; set; } = string.Empty;

    // Email address of the clinician
    public string Email { get; set; } = string.Empty;

    // Date of birth of the clinician
    public DateTime DOB { get; set; }

    // Gender of the clinician
    public Gender Gender { get; set; }

    // Phone number of the clinician
    public string Phone { get; set; } = string.Empty;

    // Specialization of the clinician (Cardiologist, Dermatologist)
    public Specialization Specialization { get; set; }

    // Work shift of the clinician (Morning, Evening)
    public string WorkShift { get; set; } = string.Empty;

    //New Property for do megratoin 2:
    public string description { get; set; } = string.Empty;

    // Foreign key:
    // Navigation property for the clinician's address
    public Address Address { get; set; } = new Address();

    // Many-to-Many Relationship:
    // List of patients associated with the clinician
    public List<Patient> Patients { get; set; } = new List<Patient>();

    // Navigation properties:
    // List of appointments associated with the clinician
    public List<Appointment> Appointments { get; set; } = new List<Appointment>();
}
