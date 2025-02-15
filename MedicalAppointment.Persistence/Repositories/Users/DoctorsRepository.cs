
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
    public class DoctorsRepository : BaseRepository<Doctors>, IDoctorsRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<DoctorsRepository> _logger;
        private readonly IConfiguration _configuration;
        public DoctorsRepository(MedicalAppointmentContext context, ILogger<DoctorsRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public override Task<bool> ExistsAsync(Expression<Func<Doctors, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<Doctors>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<Doctors, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<Doctors> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(Doctors entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(Doctors entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
