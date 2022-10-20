using System;
using FluentValidation;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;

public class GetAuthorDetailValidator : AbstractValidator<GetAuthorDetail>
{
    public GetAuthorDetailValidator()
    {
        RuleFor(query => query.AuthorId).GreaterThan(0);
    }
}