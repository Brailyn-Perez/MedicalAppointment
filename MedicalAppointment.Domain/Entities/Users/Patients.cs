using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Insurance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.User.Users
{
    public class Patients : IsActive
    {
        [Column("PatientID")]
        [Key]
        public int PatientID { get; set; }
        [Required]
        [NotNull]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [NotNull]
        public char Gender { get; set; }
        [Required]
        [NotNull]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [NotNull]
        [MinLength(10)]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(100)]
        public string EmergencyContactName { get; set; }
        [Required]
        [NotNull]
        [MaxLength(15)]
        public string EmergencyContactPhone { get; set; }
        [Required]
        [NotNull]
        [MinLength(2)]
        [MaxLength(2)]
        public string BloodType { get; set; }
        [Required]
        [NotNull]
        public string Allergies { get; set; }


        public int InsuranceProviderID { get; set; }
        public virtual InsuranceProviders InsuranceProvider { get; set; }

    }
}
