
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Users;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Users
{
    public class PatientsRepository : BaseRepository<Patients>, IPatientsRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<PatientsRepository> _logger;
        private readonly IConfiguration _configuration;

        public PatientsRepository(MedicalAppointmentContext context, ILogger<PatientsRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }

        public override Task<bool> ExistsAsync(Expression<Func<Patients, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<Patients>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<Patients, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<Patients> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(Patients entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(Patients entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
