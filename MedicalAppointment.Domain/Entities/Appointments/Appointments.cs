using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.System;
using MedicalAppointment.Domain.Entities.User.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Appointments
{
    public class Appointments : AuditoryEntity
    {
        [Key]
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int StatusID { get; set; }


        public virtual Patients Patient { get; set; }
        public virtual Doctors Doctor { get; set; }
        public virtual Status Status { get; set; }
    }
}
