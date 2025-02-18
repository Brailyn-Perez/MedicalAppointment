using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Domain.Repository;

namespace MedicalAppointment.Persistence.Interfaces.Appointments
{
    public interface IDoctorAvailabilityRepository : IBaseRepository<DoctorAvailability>
    {
        Task<OperationResult> GetAvailabilityByDoctorAsync(int doctorId);
        Task<OperationResult> SetDoctorAvailabilityAsync(DoctorAvailability availability);

    }
}
