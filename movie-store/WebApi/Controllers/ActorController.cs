using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.ActorOperations.Queries.GetActors;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]s")]
public class ActorController : ControllerBase
{
    private readonly IMovieStoreDbContext _context;
    private readonly IMapper _mapper;
    public ActorController(IMovieStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetActors()
    {
        GetActorsQuery query = new GetActorsQuery(_context, _mapper);
        var result = query.Handle();
        return Ok(result);
    }
}
