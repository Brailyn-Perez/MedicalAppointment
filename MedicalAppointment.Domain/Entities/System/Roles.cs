using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.System
{
    public class Roles : IsActive
    {
        [Column("RoleID")]
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
