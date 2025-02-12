
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

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
    }
}
