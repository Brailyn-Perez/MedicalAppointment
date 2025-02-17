using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Domain.Repository;
namespace MedicalAppointment.Persistence.Interfaces.Appointments
{
    public interface IAppointmentsRepository : IBaseRepository<Domain.Entities.Appointments.Appointments>
    {
        Task<OperationResult> GetAppointmentsByPatientAsync(int patientId);
        Task<OperationResult> GetAppointmentsByDoctorAsync(int doctorId);
        Task<OperationResult> CancelAppointmentAsync(int appointmentId);
    }
}
