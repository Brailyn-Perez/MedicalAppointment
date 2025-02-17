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

        public async Task<OperationResult> CancelAppointmentAsync(int Id)
        {
            OperationResult result = new OperationResult();
            try
            {
                var appointment = await _context.Appointments.FindAsync(Id);

                if (appointment != null)
                {
                    appointment.StatusID = 2;
                    await _context.SaveChangesAsync();

                }

            }
            catch (Exception ex)
            {
                result.Message = _configuration["ErrorAppointmentsRepository:CancelAppointmentAsync"];
                result.Success = false;
                _logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public async Task<OperationResult> GetAppointmentsByDoctorAsync(int doctorId)
        {
            OperationResult result = new OperationResult();
            try
            {
                var query = _context.Appointments
                            .Where(a => a.DoctorID == doctorId)
                            .Include(a => a.PatientID)
                            .ToListAsync();

                result.Data = query;
            }
            catch (Exception ex)
            {
                result.Message = _configuration["ErrorAppointmentsRepository:CancelAppointmentAsync"];
                result.Success = false;
                _logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public async Task<OperationResult> GetAppointmentsByPatientAsync(int patientId)
        {
            OperationResult result = new OperationResult();
            try
            {
                var query = _context.Appointments
                             .Where(a => a.PatientID == patientId)
                             .Include(a => a.DoctorID)
                              .ToListAsync();
                result.Data = query;
            }
            catch (Exception ex)
            {
                result.Message = _configuration["ErrorAppointmentsRepository:CancelAppointmentAsync"];
                result.Success = false;
                _logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
    }
}
