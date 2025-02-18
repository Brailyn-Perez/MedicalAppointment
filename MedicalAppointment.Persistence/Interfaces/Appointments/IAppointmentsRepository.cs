using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Domain.Repository;
namespace MedicalAppointment.Persistence.Interfaces.Appointments
{
    public interface IAppointmentsRepository : IBaseRepository<Domain.Entities.Appointments.Appointments>
    {
        public Task<OperationResult> ApproveAppointment(Domain.Entities.Appointments.Appointments appointments);
        public Task<OperationResult> RejectAppointment(Domain.Entities.Appointments.Appointments appointments);
        public Task<OperationResult> RescheduleAppointment(Domain.Entities.Appointments.Appointments appointments);
        public Task<OperationResult> CancelAppointment();
        public Task<OperationResult> GetAppointmentHistory();
    }
}
