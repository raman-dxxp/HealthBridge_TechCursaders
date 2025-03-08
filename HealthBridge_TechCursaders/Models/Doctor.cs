namespace HealthBridge_TechCursaders.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }

}
