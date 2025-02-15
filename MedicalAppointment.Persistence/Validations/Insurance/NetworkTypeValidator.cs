
using FluentValidation;
using MedicalAppointment.Domain.Entities.Insurance;

namespace MedicalAppointment.Persistence.Validations.Insurance
{
    public class NetworkTypeValidator : AbstractValidator<NetworkType>
    {
        public NetworkTypeValidator() { }
    }
}
