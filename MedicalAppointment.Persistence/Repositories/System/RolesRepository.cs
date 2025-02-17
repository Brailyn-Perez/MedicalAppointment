
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
    public class RolesRepository : BaseRepository<Roles>, IRolesRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<RolesRepository> _logger;
        private readonly IConfiguration _configuration;

        public RolesRepository(MedicalAppointmentContext context, ILogger<RolesRepository> logger, IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;
        }

    }
}
