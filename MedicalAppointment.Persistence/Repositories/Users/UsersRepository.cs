
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Users;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Users
{
    public class UsersRepository : BaseRepository<Domain.Entities.Users.Users>, IUsersRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<UsersRepository> _logger;
        private readonly IConfiguration _configuration;
        public UsersRepository(MedicalAppointmentContext context , ILogger<UsersRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public Task<OperationResult> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetUsersByRoleAsync(int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> UpdateUserAsync(Domain.Entities.Users.Users user)
        {
            throw new NotImplementedException();
        }
    }
}
