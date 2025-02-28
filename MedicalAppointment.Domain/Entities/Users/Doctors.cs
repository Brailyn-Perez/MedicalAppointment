using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.User.Users
{
    public class Doctors : IsActive
    {
        [Column("DoctorID")]
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int DoctorID { get; set; }
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int SpecialtyID { get; set; }
        [Required]
        [NotNull]
        [MinLength(5)]
        [MaxLength(50)]
        public string LicenseNumber { get; set; }
        [Required]
        [NotNull]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [NotNull]
        [Range(0,100)]
        public int YearsOfExperience { get; set; }
        [Required]
        [NotNull]
        public string Education { get; set; }
        public string? Bio { get; set; }
        [MaxLength(10)]
        public decimal? ConsultationFee { get; set; }
        [MaxLength(255)]
        public string? ClinicAddress { get; set; }
        public int? AvailabilityModeId { get; set; }  
        public DateTime LicenseExpirationDate { get; set; }


        public virtual Specialties Specialty { get; set; }
        public virtual AvailabilityModes AvailabilityMode { get; set; }
    }
}
