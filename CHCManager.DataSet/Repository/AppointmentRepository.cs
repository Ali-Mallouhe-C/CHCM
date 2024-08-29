using CHCManager.Domain.Modul;

namespace CHCManager.DataSet.Repository;

public class AppointmentRepository : Repository<Appointment>
{
    // Constructor to initialize the AppointmentRepository with a new database context
    public AppointmentRepository() : base(new CHCManagerDbContext())
    {
    }

    // Method to delete an appointment by its ID
    public void Delete(int id)
    {
        // Use a new database context to find and delete the appointment
        using (var context = new CHCManagerDbContext())
        {
            // Find the appointment by its ID
            var entity = context.Appointments.Find(id);
            if (entity != null)
            {
                // Call the base class method to delete the entity
                Delete(entity);
            }
        }
    }
}
