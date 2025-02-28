
using MedicalAppointment.Persistence.Interfaces.Appointments;
using MedicalAppointment.Persistence.Repositories.Appointments;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalAppointment.IOC.Services.API
{
    public static class Services
    {

        public static void AddAppointmentDependency(this IServiceCollection services) 
        {
            services.AddScoped<IAppointmentsRepository, AppointmentsRepository>();
        }
    }
}
