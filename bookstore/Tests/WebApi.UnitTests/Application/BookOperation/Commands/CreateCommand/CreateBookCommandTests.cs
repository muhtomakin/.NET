using TestSetup;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.BookOperations.AddBook;
using WebApi.Entities;
using FluentAssertions;
using System.Linq;


namespace Application.BookOperations.Commands.CreateCommand;

public class CreateBookCommandTests : IClassFixture<CommonTestFixture>
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public CreateBookCommandTests(CommonTestFixture testFixture)
    {
        _context = testFixture.Context;
        _mapper = testFixture.Mapper;
    }
    [Fact]
    public void WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldReturn()
    {
        var book = new Book()
        {
            Title = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldReturn", 
            PageCount = 100, 
            PublishDate = new System.DateTime(1990, 01, 10), 
            GenreId = 1
        };
        _context.Books.Add(book);
        _context.SaveChanges();

        CreateBookCommand command = new CreateBookCommand(_context, _mapper);
        command.Model = new CreateBookCommand.CreateBookModel(){Title = book.Title};

        FluentActions
            .Invoking(() => command.Handle())
            .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Book is already exist!");
    }

    [Fact]
    public void WhenValidInputTitleGiven_Book_Created()
    {
        CreateBookCommand command = new CreateBookCommand(_context, _mapper);
        CreateBookCommand.CreateBookModel model = new CreateBookCommand.CreateBookModel()
        {
            Title = "Lord Of The Rings",
            PageCount = 1200,
            PublishDate = DateTime.Now.Date.AddYears(-10),
            GenreId = 1
        };
        command.Model = model;

        FluentActions.Invoking(() => command.Handle()).Invoke();

        var book = _context.Books.SingleOrDefault(book => book.Title == model.Title);
        book.Should().NotBeNull();
        book?.PageCount.Should().Be(model.PageCount);
        book?.GenreId.Should().Be(model.GenreId);
    }
}