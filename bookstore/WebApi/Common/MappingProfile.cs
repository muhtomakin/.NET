using AutoMapper;
using WebApi.Application.BookOperations.GetById;
using WebApi.Application.BookOperations.GetBooks;
using static WebApi.Application.BookOperations.AddBook.CreateBookCommand;
using WebApi.Entities;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Application.GenreOperations.Queries.GetGenreDetail;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.UserOperations.Commands.CreateUser;
using WebApi.Application.UserOperations.Commands.UpdateUser;
using WebApi.Application.UserOperations.Queries.GetUsers;
using WebApi.Application.UserOperations.Queries.GetUserDetail;

namespace WebApi.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBookModel, Book>();
        // CreateMap<Book, BookDetailViewModel>().ForMember(dest => 
        //     dest.Genre, opt => 
        //         opt.MapFrom(src => 
        //             ((GenreEnum)src.GenreId).ToString()
        //         )
        //     );
        CreateMap<Book, BookDetailViewModel>().ForMember(dest => 
            dest.Genre, opt => 
                opt.MapFrom(src => (src.Genre.Name).ToString()
                )
            );
        CreateMap<Book, BooksViewModel>().ForMember(dest => 
            dest.Genre, opt => 
                opt.MapFrom(src => (src.Genre.Name).ToString()
                )
            );
        CreateMap<Genre, GenresViewModel>();
        CreateMap<Genre, GenreDetailViewModel>();
        CreateMap<Author, AuthorViewModel>();
        CreateMap<Author , AuthorDetailViewModel>()
            .ForMember(dest => dest.Book , opt=> opt.MapFrom(src => src.Book.Title));

        CreateMap<CreateAuthorModel, Author>();

        CreateMap<User, UsersViewModel>();
        CreateMap<User, UserDetailViewModel>();

        CreateMap<CreateUserModel, User>();
        CreateMap<UpdateUserModel, User>();
        CreateMap<CreateBookModel , User>();
    }
}
