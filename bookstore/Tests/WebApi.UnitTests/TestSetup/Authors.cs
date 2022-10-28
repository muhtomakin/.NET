using WebApi.DBOperations;
using System;
using WebApi.Entities;

namespace TestSetup;

public static class Authors
{
    public static void AddAuthors(this BookStoreDbContext context)
    {
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
}
}