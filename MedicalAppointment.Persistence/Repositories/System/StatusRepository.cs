
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

    }
}
