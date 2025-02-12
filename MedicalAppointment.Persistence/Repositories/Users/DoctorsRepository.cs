
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Users;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

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
    }
}
