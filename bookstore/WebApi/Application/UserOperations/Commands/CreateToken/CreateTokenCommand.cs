using AutoMapper;
using WebApi.DBOperations;
using WebApi.TokenOperations.Models;
using WebApi.TokenOperations;

namespace WebApi.Application.UserOperations.Commands.CreateToken;

public class CreateTokenCommand
{
    public CreateTokenModel Model;
    private readonly IMapper _mapper;
    private readonly IBookStoreDbContext _context;
    private readonly IConfiguration _configuration;

    public CreateTokenCommand(IBookStoreDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }

    public Token Handle()
    {
        var user = _context.Users.FirstOrDefault(x => x.Email == Model.Email && x.Password == Model.Password);
        if(user is null)
            throw new InvalidOperationException("User email or password false!");
        
        TokenHandler handler = new TokenHandler(_configuration);
        Token token = handler.CreateAccessToken(user);

        user.RefreshToken = token.RefreshToken;
        user.RefreshTokenExpireDate = token.Expiration.AddMinutes(5);

        _context.SaveChanges();
        return token;
    }
}

public class CreateTokenModel
{
    public string Email { get; set; }
    public string Password { get; set; }
}