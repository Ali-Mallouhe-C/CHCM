using Microsoft.EntityFrameworkCore;

namespace CHCManager.DataSet.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly CHCManagerDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(CHCManagerDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
        _dbContext.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
        _dbContext.SaveChanges();
    }

    public TEntity Get(int id)
    {
        var entity = _dbSet.Find(id);
        return entity;
    }

    public List<TEntity> GetAll()
    {
       return _dbSet.ToList();
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _dbContext.SaveChanges();
    }
}
