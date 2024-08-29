namespace CHCManager.Domain.Modul
{
    public class Address
    {
        //Address Properties:
        public int Id { get; set; }

        public string Country { get; set; } = string.Empty;
        
        public string City { get; set; } = string.Empty;
        
        public int StreetNumber { get; set; }
        
        public string BuildingName { get; set; } = string.Empty;

        //Forign keys:
        public int PatientId { get; set; }
        
        public int ClinicianId { get; set; }
    }

}
