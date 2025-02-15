using MedicalAppointment.Domain.Base;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Appointments
{
    public class AppointmentsRepository : BaseRepository<Domain.Entities.Appointments.Appointments>, IAppointmentsRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<AppointmentsRepository> _logger;
        private readonly IConfiguration _configuration;

        public AppointmentsRepository(MedicalAppointmentContext context, ILogger<AppointmentsRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public override Task<bool> ExistsAsync(Expression<Func<Domain.Entities.Appointments.Appointments, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<Domain.Entities.Appointments.Appointments>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<Domain.Entities.Appointments.Appointments, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<Domain.Entities.Appointments.Appointments> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(Domain.Entities.Appointments.Appointments entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(Domain.Entities.Appointments.Appointments entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
