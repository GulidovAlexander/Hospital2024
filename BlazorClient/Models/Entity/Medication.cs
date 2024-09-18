namespace BlazorClient.Models.Entity
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Format { get; set; }

        public int PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
    }
}
