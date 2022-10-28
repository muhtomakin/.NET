using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor;

public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
{
    public UpdateAuthorCommandValidator()
    {
        RuleFor(x => x.Model.Name).MinimumLength(2)
            .When(x => x.Model.Name != string.Empty);
        RuleFor(x => x.Model.LastName).MinimumLength(2)
            .When(x => x.Model.LastName != string.Empty);
        RuleFor(x => x.Model.BookId).NotEmpty().GreaterThan(0);
    }
}