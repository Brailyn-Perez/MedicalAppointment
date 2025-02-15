
using FluentValidation;
using MedicalAppointment.Domain.Entities.System;

namespace MedicalAppointment.Persistence.Validations.System
{
    public class NotificationsValidator : AbstractValidator<Notifications>
    {
        public NotificationsValidator() { }
    }
}
