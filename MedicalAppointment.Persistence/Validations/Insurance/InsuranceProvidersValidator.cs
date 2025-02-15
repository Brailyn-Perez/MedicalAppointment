
using FluentValidation;
using MedicalAppointment.Domain.Entities.Insurance;

namespace MedicalAppointment.Persistence.Validations.Insurance
{
    public class InsuranceProvidersValidator : AbstractValidator<InsuranceProviders>
    {
        public InsuranceProvidersValidator() { }
    }
}
