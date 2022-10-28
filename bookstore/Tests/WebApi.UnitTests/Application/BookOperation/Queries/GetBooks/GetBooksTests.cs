using TestSetup;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.BookOperations.GetBooks;
using WebApi.Entities;
using FluentAssertions;

namespace Application.BookOperations.Queries.GetBooks;

public class GetBooksTests : IClassFixture<CommonTestFixture>
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public GetBooksTests(CommonTestFixture testFixture)
    {
        _context = testFixture.Context;
        _mapper = testFixture.Mapper;
    }
    
    [Fact]
    public void WhenRequestBooks_GetBooks_ShouldBeReturn()
    {
        GetBooksQuery command = new GetBooksQuery(_context, _mapper);

        FluentActions.Invoking(() => command.Handle())
            .Should().NotBeNull();
    }
}