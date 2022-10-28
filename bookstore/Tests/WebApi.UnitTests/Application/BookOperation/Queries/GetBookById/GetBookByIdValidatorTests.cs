using TestSetup;
using WebApi.Application.BookOperations.GetById;
using FluentAssertions;



namespace Application.BookOperations.Queries.GetBookById;

public class GetBookByIdValidatorTests : IClassFixture<CommonTestFixture>
{
    [Fact]
    public void WhenFalseBookIdIsGiven_Validator_ShouldBeReturnError()
    {
        GetByIdQuery command = new GetByIdQuery(null, null);
        command.BookId = 0;

        GetByIdQueryValidator validator = new GetByIdQueryValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().BeGreaterThan(0);
    }

    [Fact]
    public void WhenTrueBookIdIsGiven_Validator_ShouldBeReturn()
    {
        GetByIdQuery command = new GetByIdQuery(null, null);
        command.BookId = 2;

        GetByIdQueryValidator validator = new GetByIdQueryValidator();
        var result = validator.Validate(command);

        result.Errors.Count.Should().Be(0);
    }
}