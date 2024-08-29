﻿using CHCManager.Domain.Modul;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHCManager.DataSet.Repository;

public class BillingRepository : Repository<Billing>
{
    public BillingRepository() : base(new CHCManagerDbContext())
    {   }

    public void Delete(int id)
    {
        using (var context = new CHCManagerDbContext())
        {
            var entity = context.Billings.Find(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }
    }



}
