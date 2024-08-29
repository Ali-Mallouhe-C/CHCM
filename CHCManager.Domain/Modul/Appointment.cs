using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul
{
    public class Appointment
    {
        public int Id { get; set; }

        public Status State { get; set; }
       
        public DateTime Date { get; set; }

        public DateTime EndDate { get; set; }

        //Forign keys:
        public int ClinicianId { get; set; }
        
        public int PatientId { get; set; }

    }

}
