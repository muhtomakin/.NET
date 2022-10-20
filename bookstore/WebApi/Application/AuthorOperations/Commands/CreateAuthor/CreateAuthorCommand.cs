using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor;

public class CreateAuthorCommand
{
    public CreateAuthorModel Model { get; set; }
    private readonly BookStoreDbContext _context;
    private readonly IMapper _mapper;
    public CreateAuthorCommand(BookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Handle()
    {
        var author = _context.Authors.SingleOrDefault(x => x.Name == Model.Name);

        if(author is not null)
            throw new InvalidOperationException("Author is already exists!");

        author = _mapper.Map<Author>(Model);

        _context.Authors.Add(author);
        _context.SaveChanges();

    }
}

public class CreateAuthorModel
{
    public int BookId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime PublishDate { get; set; }
}