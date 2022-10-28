using FluentValidation;

namespace WebApi.Application.UserOperations.Queries.GetUserDetail;

public class GetUserDetailValidator : AbstractValidator<GetUserDetail>
{
    public GetUserDetailValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
    }
}