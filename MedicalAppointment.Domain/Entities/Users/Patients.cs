using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Insurance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Entities.User.Users
{
    public class Patients : IsActive
    {
        [Column("PatientID")]
        [Key]
        public int PatientID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }


        public int InsuranceProviderID { get; set; }
        public virtual InsuranceProviders InsuranceProvider { get; set; }

    }
}
