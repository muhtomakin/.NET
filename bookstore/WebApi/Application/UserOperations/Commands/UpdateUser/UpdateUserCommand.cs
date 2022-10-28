using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.UserOperations.Commands.UpdateUser;

public class UpdateUserCommand
{
    private readonly IMapper _mapper;
    private readonly IBookStoreDbContext _context;
    public UpdateUserModel Model;
    public int UserId;

    public UpdateUserCommand(IBookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Handle()
    {
        var user = _context.Users.Find(UserId);
        if(user is null)
            throw new InvalidOperationException("User could not found!");

        _mapper.Map<UpdateUserModel, User>(Model, user);
        _context.SaveChanges();
    }
}

public class UpdateUserModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Password { get; set; }
}