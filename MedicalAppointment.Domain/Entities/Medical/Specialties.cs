using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Medical
{
    public class Specialties : IsActive
    {
        [Column("SpecialtyID")]
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [NotNull]
        [MaxLength(100)]
        [MinLength(3)]
        public string SpecialtyName { get; set; }

    }
}
