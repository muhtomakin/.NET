using WebApi.DBOperations;
using AutoMapper;
using WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;

public class GetAuthorDetail
{
    public AuthorDetailViewModel Model;
    public int AuthorId { get; set; }
    private readonly IBookStoreDbContext _context;
    private readonly IMapper _mapper;
    public GetAuthorDetail(IBookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public AuthorDetailViewModel Handle()
    {
        var author = _context.Authors.Include(x => x.Book).SingleOrDefault(x => x.Id == AuthorId);

        if(author is null)
            throw new InvalidOperationException("Author could not found!");

        return _mapper.Map<AuthorDetailViewModel>(author);
    }
}

public class AuthorDetailViewModel
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    public string Book { get; set; }
}