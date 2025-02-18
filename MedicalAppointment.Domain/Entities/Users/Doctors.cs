using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.User.Users
{
    public class Doctors : IsActive
    {
        [Column("DoctorID")]
        [Key]
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public int SpecialtyID { get; set; }
        public string LicenseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsOfExperience { get; set; }
        public string Education { get; set; }
        public string? Bio { get; set; }
        public decimal? ConsultationFee { get; set; }  
        public string? ClinicAddress { get; set; }
        public int? AvailabilityModeId { get; set; }  
        public DateTime LicenseExpirationDate { get; set; }


        public virtual Specialties Specialty { get; set; }
        public virtual AvailabilityModes AvailabilityMode { get; set; }
    }
}
