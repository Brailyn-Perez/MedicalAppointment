using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.User.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Medical
{
    public class MedicalRecords : AuditoryEntity
    {
        [Column("RecordID")]
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int RecordID { get; set; }
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int PatientID { get; set; }
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int DoctorID { get; set; }
        [Required]
        [NotNull]
        public string Diagnosis { get; set; }
        [Required]
        [NotNull]
        public string Treatment { get; set; }
        [Required]
        [NotNull]
        public DateTime DateOfVisit { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Doctors Doctor { get; set; }

    }
}
