using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.System
{
    public class Notifications
    {
        [Column("NotificationID")]
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        [Required]
        [NotNull]
        [MinLength(5)]
        public string Message { get; set; }
        public DateTime? SentAt { get; set; }

        public Users.Users User { get; set; }
    }
}
