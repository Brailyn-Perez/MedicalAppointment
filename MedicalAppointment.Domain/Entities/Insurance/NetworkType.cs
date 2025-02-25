﻿using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Insurance
{
    public class NetworkType : IsActive
    {
        [Column("NetworkTypeid")]
        [Key]
        public int NetworkTypeId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
