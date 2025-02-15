
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
    public class MedicalRecordsRepository : BaseRepository<MedicalRecords>, IMedicalRecordsRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<MedicalRecordsRepository> _logger;
        private readonly IConfiguration _configuration;

        public MedicalRecordsRepository(MedicalAppointmentContext context, ILogger<MedicalRecordsRepository> logger , IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }

        public override Task<bool> ExistsAsync(Expression<Func<MedicalRecords, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<MedicalRecords>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<MedicalRecords, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<MedicalRecords> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(MedicalRecords entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(MedicalRecords entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
