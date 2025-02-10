using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Medical
{
    public class Specialties : IsActive
    {
        [Column("SpecialtyID")]
        [Key]
        public int Id { get; set; }
        public string SpecialtyName { get; set; }

    }
}
