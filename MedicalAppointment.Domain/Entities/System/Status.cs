using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.System
{
    public class Status
    {
        [Column("StatusID")]
        [Key]
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
}
