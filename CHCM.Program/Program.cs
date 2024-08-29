using CHCManager.DataSet.Repository;
using CHCManager.Domain.Modul;

namespace CHCM.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                City = "Allepo",
                Country = "Syria",
                BuildingName = "NoName",
                StreetNumber = 1515
            };

            PatientRepository patientRepository = new PatientRepository();
            patientRepository.Add(new CHCManager.Domain.Modul.Patient()
            {
                FirstName = "ALi",
                LastName = "Mallouhe",
                DOB = new DateTime(2004,7,1),
                Address = address,
                Gender = CHCManager.Domain.Enums.Gender.Male,
                Phone = "+4433356489456"
            });

            ClinicianRepository clinicianRepository = new ClinicianRepository();
            clinicianRepository.Add(new CHCManager.Domain.Modul.Clinician()
            {
                FirstName = "Ahmad",
                LastName = "Mallouhe",
                DOB = new DateTime(1999, 7, 1),
                Address = address,
                Gender = CHCManager.Domain.Enums.Gender.Male,
                Phone = "+96433356489456",
                Specialization = CHCManager.Domain.Enums.Specialization.Neurology
            });

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            appointmentRepository.Add(new CHCManager.Domain.Modul.Appointment()
            {
                State = CHCManager.Domain.Enums.Status.Awaiting,
                Date = new DateTime(1900,1,1),
                EndDate = new DateTime(2009,2,2),
                ClinicianId = 1,
                PatientId = 1,
            });
        }
    }
}
