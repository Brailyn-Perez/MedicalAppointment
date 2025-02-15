
using FluentValidation;
using MedicalAppointment.Domain.Entities.Medical;

namespace MedicalAppointment.Persistence.Validations.Medical
{
    public class SpecialtiesValidator : AbstractValidator<Specialties>
    {
        public SpecialtiesValidator() { }
    }
}
