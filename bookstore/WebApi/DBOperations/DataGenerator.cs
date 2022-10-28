using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DBOperations;

public class DataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
        {
            if (context.Books.Any())
            {
                return;
            }

            context.Users.AddRange(
                new User 
                {
                    Name = "Thomas",
                    Surname = "Müller",
                    Email = "tmüller@gmail.com",
                    Password = "123456"
                }
            );

            context.Authors.AddRange(
                new Author 
                {
                    Name = "Franz",
                    LastName = "Kafka",
                    DateOfBirth = new DateTime(1999,06,07),
                    BookId = 1

                
                },
                new Author 
                {
                    Name = "Thomas",
                    LastName = "Müller",
                    DateOfBirth = new DateTime(1999,11,24),
                    BookId = 2
                    
                },
                new Author 
                {
                    Name = "Lisa",
                    LastName = "Mayer",
                    DateOfBirth = new DateTime(1999,10,24),
                    BookId = 3
                    
                }
            );

            context.Genres.AddRange(
                new Genre{
                    Name = "Personal Growth"
                },
                new Genre{
                    Name = "Science Fiction"
                },
                new Genre{
                    Name = "Romance"
                }
            );

            context.Books.AddRange(
                new Book
                {
                    // Id = 1,
                    Title = "Lean Startup",
                    GenreId = 1, // Personal Growth
                    PageCount = 200,
                    PublishDate = new DateTime(2001, 06, 12),
                },
                new Book
                {
                    // Id = 2,
                    Title = "Herland",
                    GenreId = 1, // Science Fiction
                    PageCount = 250,
                    PublishDate = new DateTime(2010, 05, 23),
                },
                new Book
                {
                    // Id = 3,
                    Title = "Dune",
                    GenreId = 2, // Science Fiction
                    PageCount = 540,
                    PublishDate = new DateTime(2001, 12, 21),
                }
            );

            context.SaveChanges();
        }
    }
}