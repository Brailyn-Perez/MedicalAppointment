
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Domain.Repository;

namespace MedicalAppointment.Persistence.Interfaces.Users
{
    public interface IDoctorsRepository : IBaseRepository<Doctors>
    {
        public Task<OperationResult> AssociateDoctors(IEnumerable<Specialties> specialties, Doctors doctors);
    }
}
