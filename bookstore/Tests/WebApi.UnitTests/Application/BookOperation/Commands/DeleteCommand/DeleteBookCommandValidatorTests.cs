using TestSetup;
using WebApi.Application.BookOperations.DeleteBook;
using FluentAssertions;



namespace Application.BookOperations.Commands.DeleteCommand;

public class DeleteBookCommandValidatorTests : IClassFixture<CommonTestFixture>
{
    [Fact]
    public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors()
    {
        DeleteBookCommand command = new DeleteBookCommand(null);
        command.BookId = 0;

        DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().BeGreaterThan(0);
    }

    [Fact]
    public void WhenInputsAreGiven_Validator_ShouldBeReturn()
    {
        DeleteBookCommand command = new DeleteBookCommand(null);
        command.BookId = 1; 

        DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().Be(0);
    }
}