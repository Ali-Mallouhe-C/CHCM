using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul;

public class Billing
{
    // Billing Properties:

    // Unique identifier for the billing record
    public int Id { get; set; }

    // Amount of the billing
    public float Amount { get; set; }

    // Date when the billing was created or due
    public DateTime Date { get; set; }

    // Status of the billing (e.g., Pending, Paid, Overdue)
    public Status State { get; set; }

    // Method of payment for the billing (Cash, Credit Card)
    public Method Method { get; set; }

    // Foreign key:
    // Reference to the patient associated with this billing
    public int PatientId { get; set; }

    // Navigation property to access the Patient associated with this billing
    public Patient Patient { get; set; } = new Patient();

    public Appointment Appointment { get; set; } // One-to-One relationship with Appointment
}
