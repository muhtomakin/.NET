using AutoMapper;
using WebApi.Application.BookOperations.GetById;
using WebApi.Application.BookOperations.GetBooks;
using static WebApi.Application.BookOperations.AddBook.CreateBookCommand;
using WebApi.Entities;
using WebApi.Application.GenreOperations.Queries.GetGenres;
using WebApi.Application.GenreOperations.Queries.GetGenreDetail;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;

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
    }
}
