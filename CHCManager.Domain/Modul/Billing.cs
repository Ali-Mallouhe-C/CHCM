using CHCManager.Domain.Enums;

namespace CHCManager.Domain.Modul
{
    public class Billing
    {

        //Billing Properties:
        public int Id { get; set; }

        public float Amount { get; set; }
       
        public DateTime Date { get; set; }
        
        public Status State { get; set; }
        
        public Method Method { get; set; }

        //Forign key:
        public int PatientId { get; set; }

        
    }

}
