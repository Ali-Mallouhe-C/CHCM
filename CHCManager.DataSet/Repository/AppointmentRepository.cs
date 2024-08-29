using CHCManager.Domain.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHCManager.DataSet.Repository;

public class AppointmentRepository : Repository<Appointment>
{
    public AppointmentRepository() : base(new CHCManagerDbContext())
    {   }

    public void Delete(int id)
    {
        using (var context = new CHCManagerDbContext())
        {
            var entity = context.Appointments.Find(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }
    }

}
