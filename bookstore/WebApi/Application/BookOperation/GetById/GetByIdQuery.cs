using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Application.BookOperations.GetById;

public class GetByIdQuery
{
    public int BookId { get; set; }
    private readonly IBookStoreDbContext _dbContext;
    private readonly IMapper _mapper;
    public GetByIdQuery(IBookStoreDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public BookDetailViewModel Handle()
    {
        var book = _dbContext.Books.Include(x => x.Genre).Where(book => book.Id == BookId).SingleOrDefault();
        if (book is null)
            throw new InvalidOperationException("The Book could not found!");
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