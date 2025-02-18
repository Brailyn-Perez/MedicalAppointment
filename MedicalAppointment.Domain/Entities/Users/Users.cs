using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.Users
{
    public class Users : IsActive
    {
        [Column("UserID")]
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RoleID { get; set; }


        public virtual Roles Role { get; set; }

    }
}
