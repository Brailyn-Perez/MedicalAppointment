﻿using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Medical
{
    public class AvailabilityModes : IsActive
    {
        [Column("SAvailabilityModeID")]
        [Key]
        public Int16 Id { get; set; }
        [Required]
        [NotNull]
        [MaxLength(100)]
        public string AvailabilityMode { get; set; }

    }
}
