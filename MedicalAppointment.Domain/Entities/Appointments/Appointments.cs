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
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        [Required]
        [NotNull]
        public DateTime AppointmentDate { get; set; }
        public int StatusID { get; set; }


        public Patients Patient { get; set; }
        public Doctors Doctor { get; set; }
        public Status Status { get; set; }
    }
}
