using CHCManager.Domain.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHCManager.DataSet.Repository;

public class ClinicianRepository : Repository<Clinician>
{

    public ClinicianRepository() : base(new CHCManagerDbContext())
    {   }


    public void Delete(int id)
    {
        using (var context = new CHCManagerDbContext())
        {
            var entity = context.Clinicians.Find(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }
    }

}
