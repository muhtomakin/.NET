using FluentValidation;

namespace WebApi.Application.UserOperations.Commands.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Model.Name).NotEmpty();
        RuleFor(x => x.Model.Surname).NotEmpty();
        RuleFor(x => x.Model.Password).NotEmpty().MinimumLength(6);    
    }
}