using AutoMapper;
using WebApi.BookOperations.GetById;
using WebApi.BookOperations.GetBooks;
using static WebApi.BookOperations.AddBook.CreateBookCommand;


namespace WebApi.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBookModel, Book>();
        CreateMap<Book, BookDetailViewModel>().ForMember(dest => 
            dest.Genre, opt => 
                opt.MapFrom(src => 
                    ((GenreEnum)src.GenreId).ToString()
                )
            );
        CreateMap<Book, BooksViewModel>().ForMember(dest => 
            dest.Genre, opt => 
                opt.MapFrom(src => 
                    ((GenreEnum)src.GenreId).ToString()
                )
            );
    }
}
