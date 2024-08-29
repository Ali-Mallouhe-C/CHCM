using CHCManager.Domain.Modul;

namespace CHCManager.DataSet.Repository;

public class BillingRepository : Repository<Billing>
{
    // Constructor to initialize the BillingRepository with a new database context
    public BillingRepository() : base(new CHCManagerDbContext())
    {
    }

    // Method to delete a billing record by its ID
    public void Delete(int id)
    {
        // Use a new database context to find and delete the billing record
        using (var context = new CHCManagerDbContext())
        {
            // Find the billing record by its ID
            var entity = context.Billings.Find(id);
            if (entity != null)
            {
                // Call the base class method to delete the entity
                Delete(entity);
            }
        }
    }

}
