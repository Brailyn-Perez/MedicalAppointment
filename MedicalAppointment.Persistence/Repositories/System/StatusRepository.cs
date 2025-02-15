
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.System;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.System;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.System
{
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<StatusRepository> _logger;
        private readonly IConfiguration _configuration;

        public StatusRepository(MedicalAppointmentContext context, ILogger<StatusRepository> logger , IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public override Task<bool> ExistsAsync(Expression<Func<Status, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<Status>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<Status, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<Status> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(Status entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(Status entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
