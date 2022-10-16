using System;
using FluentValidation;

namespace WebApi.BookOperations.UpdateBook;

public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
{
    public UpdateBookCommandValidator()
    {
        RuleFor(command => command.BookId).GreaterThan(0);
        RuleFor(command => command.Model.GenreId).GreaterThan(0);
        RuleFor(command => command.Model.PageCount).GreaterThan(0);
        RuleFor(command => command.Model.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
        RuleFor(command => command.Model.Title).NotEmpty();
    }
}