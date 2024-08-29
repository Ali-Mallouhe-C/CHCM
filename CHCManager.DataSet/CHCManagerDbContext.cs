using CHCManager.Domain.Modul;
using Microsoft.EntityFrameworkCore;

namespace CHCManager.DataSet
{
    public class CHCManagerDbContext : DbContext
    {

        //next, we will use DbSet to Create Tables for our Moduls in the local DB:
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinician> Clinicians { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //Now, we will use OnConfiguring to create connection with the data base
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;" +
                            "Initial Catalog = CHCM_DB");
        }

    }
}
