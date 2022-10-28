using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using AutoMapper;
using WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Application.BookOperations.GetBooks;

public class GetBooksQuery
{
    private readonly IBookStoreDbContext _dbContext;
    private readonly IMapper _mapper;
    public GetBooksQuery(IBookStoreDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public List<BooksViewModel> Handle()
    {
        var bookList = _dbContext.Books.Include(x => x.Genre).OrderBy(x => x.Id).ToList<Book>();
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