using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.System
{
    public class Status
    {
        [Column("StatusID")]
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(50)]
        public string StatusName { get; set; }
    }
}
