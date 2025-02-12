
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Users;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MedicalAppointment.Persistence.Repositories.Users
{
    public class PatientsRepository : BaseRepository<Patients>, IPatientsRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<PatientsRepository> _logger;
        private readonly IConfiguration _configuration;

        public PatientsRepository(MedicalAppointmentContext context, ILogger<PatientsRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }
    }
}
