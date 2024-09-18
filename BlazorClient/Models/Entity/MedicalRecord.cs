namespace BlazorClient.Models.Entity
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }
        public DateTime VisiteData { get; set; }
        public string Anamnesis { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentRecommendations { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }

        public ICollection<Referral> Referrals { get; set; }
    }
}
