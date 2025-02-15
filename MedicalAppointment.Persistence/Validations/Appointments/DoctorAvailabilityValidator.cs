
using FluentValidation;
using MedicalAppointment.Domain.Entities.Appointments;

namespace MedicalAppointment.Persistence.Validations.Appointments
{
    public class DoctorAvailabilityValidator : AbstractValidator<DoctorAvailability>
    {
        public DoctorAvailabilityValidator() { }
    }
}
