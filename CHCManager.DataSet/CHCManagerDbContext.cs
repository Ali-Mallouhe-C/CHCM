using CHCManager.Domain.Modul;
using Microsoft.EntityFrameworkCore;

namespace CHCManager.DataSet;

public class CHCManagerDbContext : DbContext
{
    // DbSets represent tables in the database
    public DbSet<Patient> Patients { get; set; }       // Table for Patient entities
    public DbSet<Clinician> Clinicians { get; set; }   // Table for Clinician entities
    public DbSet<Appointment> Appointments { get; set; } // Table for Appointment entities
    public DbSet<Billing> Billings { get; set; }       // Table for Billing entities
    public DbSet<Address> Addresses { get; set; }      // Table for Address entities

    // Configures the context to use a specific database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Specifies the connection string for the local SQL Server database
        optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;" +
                        "Initial Catalog = CHCM_DB");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure one-to-one relationship between Billing and Appointment
        modelBuilder.Entity<Billing>()
            .HasOne(b => b.Appointment) // Each Billing has one Appointment
            .WithOne(a => a.Billing) // Each Appointment has one Billing
            .HasForeignKey<Billing>(b => b.Id); // Foreign key in Billing

        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Billing)
            .WithOne(b => b.Appointment)
            .HasForeignKey<Appointment>(a => a.Id); // Foreign key in Appointment
    }
}
