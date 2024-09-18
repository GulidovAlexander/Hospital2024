namespace BlazorClient.Models.Entity
{
    public class Referral
    {
        public int ReferralId { get; set; }
        public string Type { get; set; }
        public string Specialist { get; set; }
        public DateTime AppointmentDate { get; set; }

        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
