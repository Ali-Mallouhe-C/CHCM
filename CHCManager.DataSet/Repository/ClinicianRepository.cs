using CHCManager.Domain.Modul;

namespace CHCManager.DataSet.Repository;

public class ClinicianRepository : Repository<Clinician>
{
    // Constructor to initialize the ClinicianRepository with a new database context
    public ClinicianRepository() : base(new CHCManagerDbContext())
    {
    }

    // Method to delete a clinician by its ID
    public void Delete(int id)
    {
        // Use a new database context to find and delete the clinician
        using (var context = new CHCManagerDbContext())
        {
            // Find the clinician by its ID
            var entity = context.Clinicians.Find(id);
            if (entity != null)
            {
                // Call the base class method to delete the entity
                Delete(entity);
            }
        }
    }
}
