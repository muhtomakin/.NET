using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor;

public class UpdateAuthorCommand
{
    private readonly IBookStoreDbContext _context;
    public int AuthorId;
    public UpdateAuthorModel Model { get; set; }

    public UpdateAuthorCommand(IBookStoreDbContext context)
    {
        _context = context;
    }

    public void Handle()
    {
        var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);

        if(author is null)
            throw new InvalidOperationException("Author could not found!");

        author.BookId = Model.BookId != default ? Model.BookId: author.BookId;
        author.Name = Model.Name != default ? Model.Name : author.Name;
        author.LastName = Model.LastName != default ? Model.LastName : author.LastName;

        _context.SaveChanges();
    }
}

public class UpdateAuthorModel
{
    public int BookId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}