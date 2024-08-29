using CHCManager.Domain.Modul;

namespace CHCManager.DataSet.Repository;

public class PatientRepository : Repository<Patient>
{
    // Constructor to initialize the PatientRepository with a new database context
    public PatientRepository() : base(new CHCManagerDbContext())
    {
    }

    // Method to delete a patient by their ID
    public void Delete(int id)
    {
        // Use a new database context to find and delete the patient
        using (var context = new CHCManagerDbContext())
        {
            // Find the patient by their ID
            var entity = context.Patients.Find(id);
            if (entity != null)
            {
                // Call the base class method to delete the entity
                Delete(entity);
            }
        }
    }
}
