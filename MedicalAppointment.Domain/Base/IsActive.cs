
namespace MedicalAppointment.Domain.Base
{
    public abstract class IsActive : AuditoryEntity
    {
        protected IsActive() 
        {
            isActive = true;
        }
        public bool isActive { get; set; }
    }
}
