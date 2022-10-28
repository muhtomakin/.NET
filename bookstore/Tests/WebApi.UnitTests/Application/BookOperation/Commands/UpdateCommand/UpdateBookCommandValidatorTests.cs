using TestSetup;
using WebApi.Application.BookOperations.UpdateBook;
using FluentAssertions;



namespace Application.BookOperations.Commands.UpdateCommand;

public class UpdateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
{
    [Theory]
    [InlineData("Lord Of The Rings", 0, 0)]
    [InlineData("Lord Of The Rings", 0, 1)]
    [InlineData("", 0, 0)]
    [InlineData("", 100, 1)]
    [InlineData("Lord", 100, 0)]
    [InlineData("Lord", 0, 1)]
    [InlineData("", 100, 1)] 

    public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(string title, int pageCount, int genreId)
    {
        UpdateBookCommand command = new UpdateBookCommand(null);
        command.Model = new UpdateBookCommand.UpdateBookModel()
        {
            Title = title, 
            PageCount = pageCount, 
            PublishDate = DateTime.Now.Date.AddYears(-1), 
            GenreId = genreId 
        };

        UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().BeGreaterThan(0);
    }

    [Fact]
    public void WhenInputsAreGiven_Validator_ShouldBeReturn()
    {
        UpdateBookCommand command = new UpdateBookCommand(null);
        command.BookId = 1; 
        command.Model = new UpdateBookCommand.UpdateBookModel()
        {
            Title = "Lord Of The Rings",
            PageCount = 1200,
            GenreId = 1,
            PublishDate = DateTime.Now.Date.AddYears(-58)
        };

        UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().Be(0);
    }
}