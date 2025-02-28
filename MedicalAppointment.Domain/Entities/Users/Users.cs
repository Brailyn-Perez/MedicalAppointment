using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Users
{
    public class Users : IsActive
    {
        [Column("UserID")]
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int UserID { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [NotNull]
        [MinLength(10)]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(255)]
        public string Password { get; set; }
        [Range(1, int.MaxValue)]
        public int? RoleID { get; set; }


        public virtual Roles Role { get; set; }

    }
}
