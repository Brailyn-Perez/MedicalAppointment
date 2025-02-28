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
        public int Id { get; set; }
        public Int16 SpecialtyID { get; set; }
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
        public decimal? ConsultationFee { get; set; }
        [MaxLength(255)]
        public string? ClinicAddress { get; set; }
        public Int16 AvailabilityModeId { get; set; }  
        public DateTime LicenseExpirationDate { get; set; }


        public virtual Specialties Specialty { get; set; }
        public virtual AvailabilityModes AvailabilityMode { get; set; }
    }
}
