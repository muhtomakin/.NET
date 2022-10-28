using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.UserOperations.Queries.GetUserDetail;

public class GetUserDetail
{
    private readonly IBookStoreDbContext _context;

    private readonly IMapper _mapper;
    public int UserId;

    public GetUserDetail(IBookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public UserDetailViewModel Handle()
    {
        var user = _context.Users.SingleOrDefault(x => x.Id == UserId);
        if(user is null)
            throw new InvalidOperationException("User could not found!");

        return _mapper.Map<UserDetailViewModel>(user);
         
    }
}

public class UserDetailViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}