using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using AutoMapper;

namespace WebApi.BookOperations.GetBooks;

public class GetBooksQuery
{
    private readonly BookStoreDbContext _dbContext;
    private readonly IMapper _mapper;
    public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public List<BooksViewModel> Handle()
    {
        var bookList = _dbContext.Books.OrderBy(x => x.Id).ToList<Book>();
        List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(bookList); // new List<BooksViewModel>();
        // foreach (var book in bookList)
        // {
        //     vm.Add(new BooksViewModel(){
        //         Title = book.Title,
        //         Genre=((GenreEnum)book.GenreId).ToString(),
        //         PublishDate = book.PublishDate,
        //         PageCount = book.PageCount
        //     });
        // }
        return vm;  
    }
}

public class BooksViewModel
{
    public string Title { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishDate { get; set; }
    public string Genre { get; set; }
}