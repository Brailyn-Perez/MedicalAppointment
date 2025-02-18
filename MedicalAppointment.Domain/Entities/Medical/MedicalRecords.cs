using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.User.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Medical
{
    public class MedicalRecords : AuditoryEntity
    {
        [Column("RecordID")]
        [Key]
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime DateOfVisit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Doctors Doctor { get; set; }

    }
}
