
namespace MedicalAppointment.Domain.Base
{
    public abstract class AuditoryEntity
    {

        protected AuditoryEntity()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = null;
        }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
