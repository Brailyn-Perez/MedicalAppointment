
using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Entities.Insurance;
using MedicalAppointment.Persistence.Base;
using MedicalAppointment.Persistence.Context;
using MedicalAppointment.Persistence.Interfaces.Insurance;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Repositories.Insurance
{
    public class NetworkTypeRepository : BaseRepository<NetworkType>, INetworkTypeRepository
    {
        private readonly MedicalAppointmentContext _context;
        private readonly ILogger<NetworkTypeRepository> _logger;
        private readonly IConfiguration _configuration;

        public NetworkTypeRepository(MedicalAppointmentContext context, ILogger<NetworkTypeRepository> logger , IConfiguration configuration) : base(context)
        {
            _context = context;
            _logger = logger;
            _configuration = configuration;

        }

        public override Task<bool> ExistsAsync(Expression<Func<NetworkType, bool>> filter)
        {
            return base.ExistsAsync(filter);
        }

        public override Task<List<NetworkType>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<OperationResult> GetAllAsync(Expression<Func<NetworkType, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }

        public override Task<NetworkType> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<OperationResult> SaveEntityAsync(NetworkType entity)
        {
            return base.SaveEntityAsync(entity);
        }

        public override Task<OperationResult> UpdateEntityAsync(NetworkType entity)
        {
            return base.UpdateEntityAsync(entity);
        }
    }
}
