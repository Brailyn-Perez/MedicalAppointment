
using FluentValidation;

namespace MedicalAppointment.Persistence.Validations.Appointments
{
    public class AppointmentsValidator : AbstractValidator<Domain.Entities.Appointments.Appointments>
    {
        public AppointmentsValidator()
        {
            RuleFor(x => x.PatientID).NotNull().GreaterThan(1).WithMessage("Error en el id del paciente");
            RuleFor(x => x.DoctorID).NotNull().GreaterThan(1).WithMessage("Error en el id del doctor");
            RuleFor(x => x.AppointmentDate).Empty();
            RuleFor(x => x.StatusID).NotNull().GreaterThan(1).WithMessage("Error en el id del Status");
        }
    }
}
