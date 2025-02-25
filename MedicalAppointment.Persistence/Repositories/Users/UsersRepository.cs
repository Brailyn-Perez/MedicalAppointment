﻿
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

        public Task<OperationResult> Login(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RecoverPassword()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RegisterUsers(Domain.Entities.Users.Users users)
        {
            throw new NotImplementedException();
        }
    }
}
