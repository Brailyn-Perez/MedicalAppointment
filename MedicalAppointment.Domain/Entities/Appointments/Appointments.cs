using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.System;
using MedicalAppointment.Domain.Entities.User.Users;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Appointments
{
    public class Appointments : AuditoryEntity
    {
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int AppointmentID { get; set; }
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
        public DateTime AppointmentDate { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int StatusID { get; set; }


        public virtual Patients Patient { get; set; }
        public virtual Doctors Doctor { get; set; }
        public virtual Status Status { get; set; }
    }
}
