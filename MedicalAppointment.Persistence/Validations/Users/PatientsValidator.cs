﻿
using FluentValidation;
using MedicalAppointment.Domain.Entities.User.Users;

namespace MedicalAppointment.Persistence.Validations.Users
{
    public class PatientsValidator : AbstractValidator<Patients>
    {
        public PatientsValidator() { }
    }
}
