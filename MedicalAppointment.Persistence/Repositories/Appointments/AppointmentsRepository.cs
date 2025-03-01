using MedicalAppointment.Domain.Base;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Appointments;
using Microsoft.EntityFrameworkCore;
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

        public AppointmentsRepository(MedicalAppointmentContext context,
                                      ILogger<AppointmentsRepository> logger,
                                      IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

        public override Task<OperationResult> SaveEntityAsync(Domain.Entities.Appointments.Appointments entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override async Task<OperationResult> UpdateEntityAsync(Domain.Entities.Appointments.Appointments entity)
        {
            OperationResult result = new OperationResult();

            var isValid = await BaseValidator<Domain.Entities.Appointments.Appointments>.ValidateNull(entity);
            if (!isValid.Success)
                return isValid;

            var isValidID = await BaseValidator<Domain.Entities.Appointments.Appointments>.ValidateNull(entity);
            if (!isValidID.Success)
                return isValidID;

            var exist = await base.ExistsAsync(x => x.AppointmentID == entity.AppointmentID);
            if(exist)
                return await base.UpdateEntityAsync(entity);
            else
            {
                result.Message = "the appointment no exist";
                result.Success = false;
                return result;
            }
        }

        public override async Task<List<Domain.Entities.Appointments.Appointments>> GetAllAsync()
        {
            return await _context.Appointments
                .Include(x => x.Patient)
                .Include(x => x.Doctor)
                .Include(x => x.Status)
                .ToListAsync();
        }

        public override Task<OperationResult> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}
