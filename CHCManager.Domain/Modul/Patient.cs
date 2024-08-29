using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul;

public class Patient
{
    // Patient Properties:

    // Unique identifier for the patient
    public int Id { get; set; }

    // First name of the patient
    public string FirstName { get; set; } = string.Empty;

    // Last name of the patient
    public string LastName { get; set; } = string.Empty;

    // Email address of the patient
    public string Email { get; set; } = string.Empty;

    // Date of birth of the patient
    public DateTime DOB { get; set; }

    // Gender of the patient
    public Gender Gender { get; set; }

    // Phone number of the patient
    public string Phone { get; set; } = string.Empty;

    // Foreign key:
    // Navigation property for the patient's address
    public Address Address { get; set; } = new Address();

    // Many-to-Many Relationship:
    // List of clinicians associated with the patient
    public List<Clinician> Clinicians { get; set; } = new List<Clinician>();

    // Navigation properties:
    // List of billings associated with the patient
    public List<Billing> Billings { get; set; } = new List<Billing>();

    // List of appointments associated with the patient
    public List<Appointment> Appointments { get; set; } = new List<Appointment>();
}
