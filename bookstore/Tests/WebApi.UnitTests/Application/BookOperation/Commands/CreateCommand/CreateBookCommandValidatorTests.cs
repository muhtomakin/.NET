using TestSetup;
using WebApi.Application.BookOperations.AddBook;
using FluentAssertions;



namespace Application.BookOperations.Commands.CreateCommand;

public class CreateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
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
        CreateBookCommand command = new CreateBookCommand(null, null);
        command.Model = new CreateBookCommand.CreateBookModel()
        {
            Title = title, 
            PageCount = pageCount, 
            PublishDate = DateTime.Now.Date.AddYears(-1), 
            GenreId = genreId 
        };

        CreateBookCommandValidator validator = new CreateBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().BeGreaterThan(0);
    }

    [Fact]
    public void WhenDateTimeNowIsGiven_Validator_ShouldBeReturnError()
    {
        CreateBookCommand command = new CreateBookCommand(null, null);
        command.Model = new CreateBookCommand.CreateBookModel()
        {
            Title = "Lord Of The Rings",
            PageCount = 1200,
            GenreId = 2,
            PublishDate = DateTime.Now.Date
        };

        CreateBookCommandValidator validator = new CreateBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().BeGreaterThan(0);
    }

    [Fact]
    public void WhenValidInOutsAreGiven_Validator_ShouldNotBeReturnError()
    {
        CreateBookCommand command = new CreateBookCommand(null, null);
        command.Model = new CreateBookCommand.CreateBookModel()
        {
            Title = "Lord Of The Rings",
            PageCount = 1200,
            GenreId = 1,
            PublishDate = DateTime.Now.Date.AddYears(-2)
        };

        CreateBookCommandValidator validator = new CreateBookCommandValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().Be(0);
    }
}