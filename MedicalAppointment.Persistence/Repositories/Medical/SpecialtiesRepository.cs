
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Medical;
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

        public override Task<bool> ExistsAsync(Expression<Func<Specialties, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<Specialties>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<Specialties, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<Specialties> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(Specialties entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(Specialties entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
