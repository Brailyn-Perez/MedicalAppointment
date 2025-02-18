
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Appointments;
using Microsoft.EntityFrameworkCore;
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

        public async Task<OperationResult> GetAvailabilityByDoctorAsync(int doctorId)
        {
            OperationResult result = new OperationResult();
            try
            {
                var query = await _context.DoctorAvailabilities
                     .Where(d => d.DoctorID == doctorId).ToListAsync();

                result.Data = query;
                        
            }
            catch (Exception ex)
            {
                result.Message = _configuration["ErrorDoctorAvailabilityRepository:GetAvailabilityByDoctorAsync"];
                result.Success = false;
                _logger.LogError(result.Message, ex.ToString());

            }


            return result;
        }

        public async Task SetDoctorAvailabilityAsync(DoctorAvailability availability)
        {
            _context.DoctorAvailabilities.Add(availability);
            await _context.SaveChangesAsync();
        }
    }
}
