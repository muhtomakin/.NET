using WebApi.DBOperations;
using AutoMapper;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors;

public class GetAuthors
{
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public GetAuthors(BookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<AuthorViewModel> Handle()
    {
        var authors = _context.Authors.OrderBy(x => x.Id).ToList();
        List<AuthorViewModel> values = _mapper.Map<List<AuthorViewModel>>(authors);
        return values;
    }
}

public class AuthorViewModel{
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}