using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.UserOperations.Queries.GetUsers;

public class GetUsers
{
    private readonly IMapper _mapper;
    private readonly IBookStoreDbContext _context;
    public UsersViewModel Model;

    public GetUsers(IBookStoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<UsersViewModel> Handle()
    {
        var users = _context.Users.OrderBy(x => x.Id).ToList();

        List<UsersViewModel> model = _mapper.Map<List<UsersViewModel>>(users);
        return model;
    }
}

public class UsersViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}