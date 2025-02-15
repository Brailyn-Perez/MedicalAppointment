
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Appointments
{
    public class DoctorAvailabilityRepository : BaseRepository<DoctorAvailability> , IDoctorAvailabilityRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<DoctorAvailabilityRepository> _logger;
        private readonly IConfiguration _configuration;

        public DoctorAvailabilityRepository(MedicalAppointmentContext context, ILogger<DoctorAvailabilityRepository> logger, IConfiguration configuration ) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public override Task<bool> ExistsAsync(Expression<Func<DoctorAvailability, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<DoctorAvailability>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<DoctorAvailability, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<DoctorAvailability> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(DoctorAvailability entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(DoctorAvailability entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
