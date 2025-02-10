using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Medical
{
    public class AvailabilityModes : IsActive
    {
        [Column("SAvailabilityModelID")]
        [Key]
        public int Id { get; set; }
        public string AvailabilityMode { get; set; }

    }
}
