using TestSetup;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.BookOperations.UpdateBook;
using WebApi.Entities;
using FluentAssertions;

namespace Application.BookOperations.Commands.UpdateCommand;

public class UpdateBookCommandTests : IClassFixture<CommonTestFixture>
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public UpdateBookCommandTests(CommonTestFixture testFixture)
    {
        _context = testFixture.Context;
    }
    
    [Fact]
    public void WhenFalseBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
    {
        UpdateBookCommand command = new UpdateBookCommand(_context);
        command.BookId = 99999999;

        FluentActions.Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should()
            .Be("Book is not exist!");
    }

    [Fact]
    public void WhenUpdateModelGiven_Update_ShouldBeReturn()
    {
        UpdateBookCommand command = new UpdateBookCommand(_context);
        UpdateBookCommand.UpdateBookModel model = new UpdateBookCommand.UpdateBookModel()
        {
            Title = "Lord Of The Rings",
            PageCount = 1200,
            GenreId = 1,
            PublishDate = DateTime.Now.Date.AddYears(-58)
        };
        command.Model = model;
        command.BookId = 1;

        FluentActions.Invoking(() => command.Handle()).Invoke();

        var book = _context.Books.SingleOrDefault(book => book.Title == model.Title);
        book.Should().NotBeNull();
        book.GenreId.Should().Be(model.GenreId);
    }
}