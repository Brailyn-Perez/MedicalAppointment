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

        public Task<OperationResult> ApproveAppointment(Domain.Entities.Appointments.Appointments appointments)
        {
            throw new NotImplementedException(); 
        }

        public Task<OperationResult> CancelAppointment()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetAppointmentHistory()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RejectAppointment(Domain.Entities.Appointments.Appointments appointments)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RescheduleAppointment(Domain.Entities.Appointments.Appointments appointments)
        {
            throw new NotImplementedException();
        }
    }
}
