
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Medical;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Medical
{
    public class SpecialtiesRepository : BaseRepository<Specialties>, ISpecialtiesRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<SpecialtiesRepository> _logger;
        private readonly IConfiguration _configuration;

        public SpecialtiesRepository(MedicalAppointmentContext context, ILogger<SpecialtiesRepository> logger , IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }

        public Task<OperationResult> AssociateDoctors(Specialties specialties, Doctors doctors)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> GetDoctorsByIdSpecialities(int id)
        {
            throw new NotImplementedException();
        }
    }
}
