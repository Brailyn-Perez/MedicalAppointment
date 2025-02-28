using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Insurance
{
    public class NetworkType : IsActive
    {
        [Column("NetworkTypeid")]
        [Key]
        [NotNull]
        [Range(1,int.MaxValue)]
        [Required]
        public int NetworkTypeId { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }

    }
}
