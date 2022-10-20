using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.GenreOperations.Commands.DeleteGenre;

public class DeleteGenreCommand
{
    public int GenreId { get; set; }
    private readonly BookStoreDbContext _context;

    public DeleteGenreCommand(BookStoreDbContext context)
    {
        _context = context;
    }

    public void Handle()
    {
        var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreId);
        if(genre is null)
            throw new InvalidOperationException("Book category could nnot found!");
        
        _context.Genres.Remove(genre);
        _context.SaveChanges();
    }
}
