using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DBOperations;
public class DataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
        {
            if (context.Movies.Any())
            {
                return;
            }

            context.Directors.AddRange(
                new Director { Name = "Chad", LastName = "Stahelski", FilmsDirected = "John Wick" },
                new Director { Name = "Kyle", LastName = "Balda", FilmsDirected = "Minions 2i" },
                new Director { Name = "Jonathan", LastName = "Del Val", FilmsDirected = "Minions 2" }
            );

            context.Actors.AddRange(
                new Actor { Name = "Keanu", LastName = "Reeves", PlayedMovies = "John Wick" },
                new Actor { Name = "Chad", LastName = "Stahelski", PlayedMovies = "John Wick" },
                new Actor { Name = "Bridget", LastName = "Moynahan", PlayedMovies = "John Wick" },
                new Actor { Name = "lan", LastName = "McShane", PlayedMovies = "John Wick" },
                new Actor { Name = "Steve", LastName = "Carell", PlayedMovies = "Minions 2" },
                new Actor { Name = "Alan", LastName = "Arkin", PlayedMovies = "Minions 2" }
            );

            context.Movies.AddRange(
                new Movie
                {
                    GenreId = 1,
                    Title = "John Wick",
                    Year = "2014",
                    Director = "Chad Stahelski",
                    Actors = "Keanu Reeves, Chad Stahelski, Bridget Moynahan, lan McShane ",
                    Price = 50,
                },
                new Movie
                {
                    GenreId = 3,
                    Title = "Minions 2",
                    Year = "2022",
                    Director = "Kyle Balda, Jonathan Del Val",
                    Actors = " Steve Carell, Alan Arkin",
                    Price = 45,
                }
            );

            context.Genres.AddRange(
                new Genre
                {
                    Name = "Action"
                },
                new Genre
                {
                    Name = "Science Fiction"
                },
                new Genre
                {
                    Name = "Animation"
                }
            );

            context.Customers.AddRange(
                new Customer
                {
                    Name = "Thomas",
                    LastName = "Müller",
                    Email = "tmüller@gmail.com",
                    Password = "123456",
                },
                new Customer
                {
                    Name = "Malik",
                    LastName = "Tomakin",
                    Email = "mtomakin@gmail.com",
                    Password = "123456",
                }
            );

            context.Orders.AddRange(
                new Order { CustomerId = 1 , MovieId = 1, purchasedTime = new DateTime(2022, 07, 06) },
                new Order { CustomerId = 2 , MovieId = 1, purchasedTime = new DateTime(2022, 12, 05) },
                new Order { CustomerId = 3 , MovieId = 2, purchasedTime = new DateTime(2022, 08, 25) }
                );

            context.SaveChanges();
        }
    }
}