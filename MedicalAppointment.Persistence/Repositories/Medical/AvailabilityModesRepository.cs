
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Medical;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Medical
{
    public class AvailabilityModesRepository : BaseRepository<AvailabilityModes>, IAvailabilityModesRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<AvailabilityModesRepository> _logger;
        private readonly IConfiguration _configuration;

        public AvailabilityModesRepository(MedicalAppointmentContext context , ILogger<AvailabilityModesRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }

        public override Task<bool> ExistsAsync(Expression<Func<AvailabilityModes, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<AvailabilityModes>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<AvailabilityModes, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<AvailabilityModes> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(AvailabilityModes entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(AvailabilityModes entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
