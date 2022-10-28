using TestSetup;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.BookOperations.DeleteBook;
using WebApi.Entities;
using FluentAssertions;

namespace Application.BookOperations.Commands.DeleteCommand;

public class DeleteBookCommandTests : IClassFixture<CommonTestFixture>
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public DeleteBookCommandTests(CommonTestFixture testFixture)
    {
        _context = testFixture.Context;
    }
    
    [Fact]
    public void WhenFalseBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
    {
        DeleteBookCommand command = new DeleteBookCommand(_context);
        command.BookId = 99999999;

        FluentActions.Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should()
            .Be("The book could not found!");
    }

    [Fact]
    public void WhenTrueBookIdIsGiven_Update_ShouldBeReturn()
    {
        DeleteBookCommand command = new DeleteBookCommand(_context);
        command.BookId = 1;

        FluentActions.Invoking(() => command.Handle()).Invoke();

        var book = _context.Books.SingleOrDefault(book => book.Id == command.BookId);
        book.Should().BeNull();
    }
}