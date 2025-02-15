
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

        public override Task<bool> ExistsAsync(Expression<Func<Domain.Entities.Users.Users, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<Domain.Entities.Users.Users>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<Domain.Entities.Users.Users, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<Domain.Entities.Users.Users> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(Domain.Entities.Users.Users entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(Domain.Entities.Users.Users entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
