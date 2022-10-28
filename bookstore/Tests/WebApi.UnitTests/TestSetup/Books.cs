using WebApi.DBOperations;
using System;
using WebApi.Entities;

namespace TestSetup;

public static class Books
{
    public static void AddBooks(this BookStoreDbContext context)
    {
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
    }
}