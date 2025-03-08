namespace HealthBridge_TechCursaders.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public string Medicine { get; set; }
        public string Dosage { get; set; }
        public string Notes { get; set; }
    }

}
