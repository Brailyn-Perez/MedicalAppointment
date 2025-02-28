using MedicalAppointment.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MedicalAppointment.Domain.Entities.Insurance
{
    public class InsuranceProviders : IsActive
    {
        [Key]
        [Required]
        [NotNull]
        [Range(1, int.MaxValue)]
        public int InsuranceProviderID { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(15)]
        public string ContactNumber { get; set; }
        [Required]
        [EmailAddress]
        [NotNull]
        [MinLength(10)]
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(255)]
        public string? Website { get; set; }
        [Required]
        [NotNull]
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string? City { get; set; }
        [MaxLength(100)]
        public string? State { get; set; }
        [MaxLength(100)]
        public string? Country { get; set; }
        [MaxLength(100)]
        public string? ZipCode { get; set; }
        [Required]
        [NotNull]
        public string CoverageDetails { get; set; }
        [MaxLength(255)]
        public string? LogoUrl { get; set; }
        [NotNull]
        [Required]
        public bool IsPreferred { get; set; }
        [NotNull]
        [Required]
        [Range(1, int.MaxValue)]
        public int NetworkTypeId { get; set; }
        [MaxLength(15)]
        public string? CustomerSupportContact { get; set; }
        [MaxLength(250)]
        public string? AcceptedRegions { get; set; }
        [MaxLength(10)]
        public decimal? MaxCoverageAmount { get; set; }  


        public virtual NetworkType NetworkType { get; set; }

    }

}
