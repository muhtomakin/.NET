using TestSetup;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.BookOperations.GetById;
using WebApi.Entities;
using FluentAssertions;

namespace Application.BookOperations.Queries.GetBookById;

public class GetBookByIdTests : IClassFixture<CommonTestFixture>
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public GetBookByIdTests(CommonTestFixture testFixture)
    {
        _context = testFixture.Context;
        _mapper = testFixture.Mapper;
    }
    
    [Fact]
    public void WhenFalseBookIdIsGiven_InvalidOperationException_ShouldBeReturn()
    {
        GetByIdQuery command = new GetByIdQuery(_context, _mapper);
        command.BookId = 99999999;

        FluentActions.Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should()
            .Be("The Book could not found!");
    }

    [Fact]
    public void WhenUpdateModelGiven_Update_ShouldBeReturn()
    {
        GetByIdQuery command = new GetByIdQuery(_context, _mapper);
        BookDetailViewModel model = new BookDetailViewModel();
        
        command.BookId = 1;

        FluentActions.Invoking(() => command.Handle()).Invoke();

        var book = _context.Books.SingleOrDefault(book => book.Id == command.BookId);
        book.Should().NotBeNull();
    }
}