namespace BlazorClient.Models.Entity
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }

        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }


        public ICollection<Medication> Medications { get; set; }
    }
}
