using Microsoft.EntityFrameworkCore;

namespace CHCManager.DataSet.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly CHCManagerDbContext _dbContext; // Reference to the local database context
    private readonly DbSet<TEntity> _dbSet; // Provides access to the table of type TEntity

    

    // Constructor to initialize the database context and the DbSet
    public Repository(CHCManagerDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    // Method to add a new entity to the database
    public void Add(TEntity entity)
    {
        _dbSet.Add(entity); // Add the entity to the DbSet
        _dbContext.SaveChanges(); // Save changes to the database
    }

    // Method to remove an existing entity from the database
    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity); // Remove the entity from the DbSet
        _dbContext.SaveChanges();
    }

    // Method to retrieve an entity by its ID
    public TEntity Get(int id)
    {
        var entity = _dbSet.Find(id); // Find the entity by its ID
        return entity; // Return the found entity
    }

    // Method to retrieve all entities of type TEntity
    public List<TEntity> GetAll()
    {
        return _dbSet.ToList(); // Retrieve all entities and return them as a list with type TEntity
    }

    // Method to update an existing entity in the database
    public void Update(TEntity entity)
    {
        _dbSet.Update(entity); // Update the entity in the DbSet
        _dbContext.SaveChanges();
    }
}
