using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Appointments
{
    public class DoctorAvailability
    {
        [Column("AvailabilityID")]
        [Key]
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
