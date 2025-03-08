using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthBridge_TechCursaders.Models
{
    public class HealthRecord
    {
        [Key]  // Explicitly define RecordId as the primary key
        public Guid RecordId { get; set; }

        [ForeignKey("Patient")]
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Provider")]
        public Guid ProviderId { get; set; }
        public Provider Provider { get; set; }

        public string RecordType { get; set; }
        public DateTime RecordDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string SourceSystem { get; set; }
        public DateTime Created { get; set; }
    }
}
