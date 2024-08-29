using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul;

public class Appointment
{
    // Unique identifier for the appointment
    public int Id { get; set; }

    // Status of the appointment (Scheduled, Completed, Cancelled)
    public Status State { get; set; }

    // Date and time when the appointment starts
    public DateTime Date { get; set; }

    // Date and time when the appointment ends
    public DateTime EndDate { get; set; }

    // Foreign keys:
    // Reference to the clinician associated with this appointment
    public int ClinicianId { get; set; }

    // Reference to the patient associated with this appointment
    public int PatientId { get; set; }

    // Navigation property:
    public Billing Billing { get; set; } = new Billing(); // One-to-One relationship with Billing
}
