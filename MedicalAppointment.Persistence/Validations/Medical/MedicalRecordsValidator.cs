
using FluentValidation;
using MedicalAppointment.Domain.Entities.Medical;

namespace MedicalAppointment.Persistence.Validations.Medical
{
    public class MedicalRecordsValidator : AbstractValidator<MedicalRecords>
    {
        public MedicalRecordsValidator()
        {
        }
    }
}
