using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHCManager.DataSet.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    void Add(TEntity entity); //Add Generec Entity
    
    TEntity Get(int id); // Read Entity By Id
    
    List<TEntity> GetAll(); // Read All Entities For T Class 
    
    void Update(TEntity entity); // Update an Entity 
    
    void Delete(TEntity entity); // Delete an Entity
}
