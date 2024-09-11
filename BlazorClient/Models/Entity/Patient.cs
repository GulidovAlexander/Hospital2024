namespace BlazorClient.Models.Entity
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FIO { get; set; }
        public int PassportSerial { get; set; }
        public int PassportNumber { get; set; }
        public string PlaceOfWork { get; set; }
        public long InsurencePolicyNumber { get; set; }
        public DateTime InsurencePolicyPeriod { get; set; }
        public string InsurencyCompany { get; set; }
        public byte[] Photo { get; set; }
    }
}
