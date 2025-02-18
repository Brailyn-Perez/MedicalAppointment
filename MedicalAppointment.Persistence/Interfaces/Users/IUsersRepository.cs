
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Users;
using MedicalAppointment.Domain.Repository;
namespace MedicalAppointment.Persistence.Interfaces.Users
{
    public interface IUsersRepository : IBaseRepository<Domain.Entities.Users.Users>
    {
        public Task<OperationResult> RegisterUsers(Domain.Entities.Users.Users users);
        public Task<OperationResult> Login(string Email , string Password);
        public Task<OperationResult> RecoverPassword();
    }
}
