using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.ActorOperations.Queries.GetActors;

public class GetActorsQuery
{
    public ActorsViewModel Model { get; set; }
    private readonly IMovieStoreDbContext _context;
    private readonly IMapper _mapper;
    public GetActorsQuery(IMovieStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<ActorsViewModel> Handle()
    {
        var actors = _context.Actors.ToList<Actor>();
        return _mapper.Map<List<ActorsViewModel>>(actors);
    }
}

public class ActorsViewModel
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PlayedMovies { get; set; }
}