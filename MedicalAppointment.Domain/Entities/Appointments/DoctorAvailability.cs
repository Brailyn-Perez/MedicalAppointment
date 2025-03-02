using MedicalAppointment.Domain.Entities.User.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Appointments
{
    public class DoctorAvailability
    {
        [Column("AvailabilityID")]
        [Key]
        public int AvailabilityID { get; set; }
        public int DoctorID { get; set; }
        [Required]
        [NotNull]
        public DateTime AvailableDate { get; set; }
        [Required]
        [NotNull]
        public TimeSpan StartTime { get; set; }
        [Required]
        [NotNull]
        public TimeSpan EndTime { get; set; }

        public Doctors Doctor { get; set; }

    }
}
