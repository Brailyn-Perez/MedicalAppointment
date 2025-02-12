
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Medical;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

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
    }
}
