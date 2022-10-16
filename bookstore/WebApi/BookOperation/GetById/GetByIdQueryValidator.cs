using System;
using FluentValidation;

namespace WebApi.BookOperations.GetById;

public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
{
    public GetByIdQueryValidator()
    {
        RuleFor(query => query.BookId).GreaterThan(0);
    }
}