using FluentValidation;

namespace WebApi.Application.UserOperations.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.Model.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Model.Name).NotEmpty();
        RuleFor(x => x.Model.Surname).NotEmpty();
        RuleFor(x => x.Model.Password).NotEmpty().MinimumLength(6);
    }
}