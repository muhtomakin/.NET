using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.DBOperations;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WebApi.Application.AuthorOperations.Commands.DeleteAuthor;
using AutoMapper;
using FluentValidation;

namespace WebApi.Controllers;

[Authorize]
[ApiController]
[Route("[controller]s")]
public class AuthorController : ControllerBase
{
    private readonly IBookStoreDbContext _context;
    private readonly IMapper _mapper;

    public AuthorController(IBookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAuthors()
    {
        GetAuthors query = new GetAuthors(_context, _mapper);
        var result = query.Handle();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetAuthorDetailQuery(int id)
    {
        GetAuthorDetail query = new GetAuthorDetail(_context, _mapper);
        query.AuthorId = id;

        GetAuthorDetailValidator validator = new GetAuthorDetailValidator();
        validator.ValidateAndThrow(query);

        var result = query.Handle();

        return Ok(result);
    }

    [HttpPost]
    public IActionResult CreateAuthor([FromBody] CreateAuthorModel newAuthor)
    {
        CreateAuthorCommand command = new CreateAuthorCommand(_context, _mapper);
        command.Model = newAuthor;
        CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
        validator.ValidateAndThrow(command);
        command.Handle();

        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAuthor(int id, [FromBody] UpdateAuthorModel updatedAuthor)
    {
        UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
        command.AuthorId = id;
        command.Model = updatedAuthor;

        UpdateAuthorCommandValidator validator = new UpdateAuthorCommandValidator();
        validator.ValidateAndThrow(command);

        command.Handle();
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAuthor(int id)
    {
        DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
        command.AuthorId = id;
        DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
        validator.ValidateAndThrow(command);
        command.Handle();

        return Ok();
    }
}
