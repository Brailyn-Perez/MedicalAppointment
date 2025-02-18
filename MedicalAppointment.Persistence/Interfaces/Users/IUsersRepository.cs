
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Users;
using MedicalAppointment.Domain.Repository;
namespace MedicalAppointment.Persistence.Interfaces.Users
{
    public interface IUsersRepository : IBaseRepository<Domain.Entities.Users.Users>
    {
        Task<OperationResult> GetUserByEmailAsync(string email);
        Task<OperationResult> GetUsersByRoleAsync(int roleId);
        Task<OperationResult> UpdateUserAsync(Domain.Entities.Users.Users user);
    }
}
