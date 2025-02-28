
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Domain.Repository;

namespace MedicalAppointment.Persistence.Interfaces.Medical
{
    public interface ISpecialtiesRepository : IBaseRepository<Specialties>
    {
    }
}
