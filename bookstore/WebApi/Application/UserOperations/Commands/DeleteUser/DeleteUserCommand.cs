using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.UserOperations.Commands.DeleteUser;

public class DeleteUserCommand
{
    private readonly IBookStoreDbContext _context;
    public int UserId;

    public DeleteUserCommand(IBookStoreDbContext context)
    {
        _context = context;
    }

    public void Handle()
    {
        var user = _context.Users.Find(UserId);

        if(user is null)
            throw new InvalidOperationException("User could not found!");

        _context.Users.Remove(user);
        _context.SaveChanges();
    }
}