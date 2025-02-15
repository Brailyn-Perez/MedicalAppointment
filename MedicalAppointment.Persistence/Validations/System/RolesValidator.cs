
using FluentValidation;
using MedicalAppointment.Domain.Entities.System;

namespace MedicalAppointment.Persistence.Validations.System
{
    public class RolesValidator : AbstractValidator<Roles>
    {
        public RolesValidator() { }
    }
}
