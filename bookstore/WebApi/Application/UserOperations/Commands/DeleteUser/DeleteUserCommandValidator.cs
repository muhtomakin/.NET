using FluentValidation;

namespace WebApi.Application.UserOperations.Commands.DeleteUser;

public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
    }
}