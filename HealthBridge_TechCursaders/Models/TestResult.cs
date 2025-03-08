namespace HealthBridge_TechCursaders.Models
{
    public class TestResult
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public string TestName { get; set; }
        public string Result { get; set; }
        public string Comments { get; set; }
    }

}
