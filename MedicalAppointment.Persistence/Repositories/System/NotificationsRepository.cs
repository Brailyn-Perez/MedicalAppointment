
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.System;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.System
{
    public class NotificationsRepository : BaseRepository<Notifications>, INotificationsRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<NotificationsRepository> _logger;
        private readonly IConfiguration _configuration;

        public NotificationsRepository(MedicalAppointmentContext context, ILogger<NotificationsRepository> logger ,IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }

    }
}
