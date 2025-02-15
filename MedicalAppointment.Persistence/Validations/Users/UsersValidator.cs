
using FluentValidation;

namespace MedicalAppointment.Persistence.Validations.Users
{
    public class UsersValidator : AbstractValidator<Domain.Entities.Users.Users>
    {
        public UsersValidator() { }
    }
}
