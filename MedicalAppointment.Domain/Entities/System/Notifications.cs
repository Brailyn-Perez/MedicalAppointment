﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.System
{
    public class Notifications
    {
        [Column("NotificationID")]
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int ID { get; set; }
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int UserID { get; set; }
        [Required]
        [NotNull]
        [MinLength(5)]
        public string Message { get; set; }
        public DateTime? SentAt { get; set; } 

        public virtual Users.Users User { get; set; }
    }
}
