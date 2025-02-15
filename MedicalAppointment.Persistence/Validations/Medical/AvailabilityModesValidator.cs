
using FluentValidation;
using MedicalAppointment.Domain.Entities.Medical;

namespace MedicalAppointment.Persistence.Validations.Medical
{
    public class AvailabilityModesValidator : AbstractValidator<AvailabilityModes>
    {
        public AvailabilityModesValidator()
        {
        }
    }
}
