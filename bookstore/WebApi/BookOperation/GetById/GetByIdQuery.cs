using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using AutoMapper;

namespace WebApi.BookOperations.GetById;

public class GetByIdQuery
{
    public int BookId { get; set; }
    private readonly BookStoreDbContext _dbContext;
    private readonly IMapper _mapper;
    public GetByIdQuery(BookStoreDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public BookDetailViewModel Handle()
    {
        var book = _dbContext.Books.Where(book => book.Id == BookId).SingleOrDefault();
        if (book is null)
            throw new InvalidOperationException("Book is not found!");
        BookDetailViewModel vm = _mapper.Map<BookDetailViewModel>(book); // new BookDetailViewModel();
        // vm.Title = book.Title;
        // vm.PageCount = book.PageCount;
        // vm.PublishDate = book.PublishDate;
        // vm.Genre = ((GenreEnum)book.GenreId).ToString();

        return vm;
    }
}

public class BookDetailViewModel
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishDate { get; set; }
}