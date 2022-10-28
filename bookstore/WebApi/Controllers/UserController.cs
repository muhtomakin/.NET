using Microsoft.AspNetCore.Mvc;
using WebApi.DBOperations;
using AutoMapper;
using WebApi.Application.UserOperations.Commands.CreateUser;
using WebApi.Application.UserOperations.Commands.RefreshToken;
using WebApi.Application.UserOperations.Commands.CreateToken;
using WebApi.TokenOperations.Models;
using FluentValidation;
using WebApi.Application.UserOperations.Commands.UpdateUser;
using WebApi.Application.UserOperations.Commands.DeleteUser;
using WebApi.Application.UserOperations.Queries.GetUsers;
using WebApi.Application.UserOperations.Queries.GetUserDetail;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]s")]
public class UserController : ControllerBase
{
    private readonly IBookStoreDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    public UserController(IBookStoreDbContext context, IConfiguration configuration, IMapper mapper)
    {
        _context = context;
        _configuration = configuration;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserModel newUser)
    {   
        CreateUserCommand command = new CreateUserCommand(_context, _mapper);
        command.Model = newUser;

        CreateUserCommandValidator validator = new CreateUserCommandValidator();
        validator.ValidateAndThrow(command);

        command.Handle();

        return Ok();
    }

    [HttpPost("connect/token")]
    public ActionResult<Token> CreateToken([FromBody] CreateTokenModel login)
    {
        CreateTokenCommand command = new CreateTokenCommand(_context, _mapper, _configuration);
        command.Model = login;
        var token = command.Handle();
        return token;
    }

    [HttpGet("refreshToken")]
    public ActionResult<Token> RefreshToken([FromQuery] string token)
    {
        RefreshTokenCommand command = new RefreshTokenCommand(_context, _configuration);
        command.RefreshToken = token;
        var result = command.Handle();
        return result;
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, [FromBody] UpdateUserModel model)
    {
        UpdateUserCommand command = new UpdateUserCommand(_context, _mapper);
        command.UserId = id;
        command.Model = model;

        UpdateUserCommandValidator validator = new UpdateUserCommandValidator();
        validator.ValidateAndThrow(command);

        command.Handle();
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        DeleteUserCommand command = new DeleteUserCommand(_context);
        command.UserId = id;

        DeleteUserCommandValidator validator = new DeleteUserCommandValidator();
        validator.ValidateAndThrow(command);

        command.Handle();
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetUserDetailById(int id)
    {
        GetUserDetail query = new GetUserDetail(_context, _mapper);
        query.UserId = id;

        GetUserDetailValidator validator = new GetUserDetailValidator();
        validator.ValidateAndThrow(query);
        
        var result = query.Handle();

        return Ok(result);
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        GetUsers query = new GetUsers(_context , _mapper);
        var result = query.Handle();

        return Ok(result);
    }
}