using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.System
{
    public class Notifications
    {
        [Column("NotificationID")]
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}
