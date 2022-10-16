using System.Linq;

namespace LinqPractices.DbOperations;

public class DataGenerator
{
    public static void Initialize()
    {
        using(var context = new LinqDbContext())
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.AddRange(
                new Student() 
                {
                    Name = "Christoph",
                    Surname = "Tomakin",
                    ClassId = 1,
                },
                new Student() 
                {
                    Name = "Thomas",
                    Surname = "Müller",
                    ClassId = 2,
                },
                new Student() 
                {
                    Name = "Lisa",
                    Surname = "Sara",
                    ClassId = 2,
                },
                new Student() 
                {
                    Name = "Margretta",
                    Surname = "Schach",
                    ClassId = 2,
                }
            );

            context.SaveChanges();
        }
    } 
}