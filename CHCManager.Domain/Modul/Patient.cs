using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul
{
    public class Patient
    {
        //Patient Properties:
        public int Id { get; set; }
        
        public string FirstName { get; set; } = string.Empty;
       
        public string LastName { get; set; } = string.Empty;
       
        public string Email { get; set; } = string.Empty;
       
        public DateTime DOB { get; set; }
       
        public Gender Gender { get; set; }
       
        public string Phone { get; set; } = string.Empty;
        
        //Forign key:
        public Address Address { get; set; } = new Address();

        //Many to Many Relation:
        public List<Clinician> Clinicians { get; set; } = new List<Clinician>();
       

        //Navigation Properties:
        public List<Billing> Billings { get; set; } = new List<Billing>();
       
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        
    }

}
