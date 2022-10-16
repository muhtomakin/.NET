using System;
using LinqPractices.DbOperations;

namespace LinqPractices;

class Program {
    static void Main(string[] args)
    {
        DataGenerator.Initialize();
        LinqDbContext _context = new LinqDbContext();
        var stundents = _context.Students.ToList<Student>();

        // Find()
        Console.WriteLine("**** Find ****");
        var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
        student = _context.Students.Find(1);
        Console.WriteLine(student.Name);

        // FirstOrDefault()
        Console.WriteLine();
        Console.WriteLine("**** FirstOrDefault ****");
        student = _context.Students.Where(student => student.Surname == "Tomakin").FirstOrDefault();
        Console.WriteLine(student.Name);

        student = _context.Students.FirstOrDefault(x => x.Surname == "Tomakin");
        Console.WriteLine(student.Name);

        // SingleOrDefault()
        Console.WriteLine();
        Console.WriteLine("**** SingleOrDefault ****");
        student = _context.Students.SingleOrDefault(student => student.Surname == "Tomakin");
        Console.WriteLine(student.Name);

        // ToList()
        Console.WriteLine();
        Console.WriteLine("**** ToList ****");
        var studentList = _context.Students.Where(student => student.ClassId == 2).ToList();
        foreach (var item in studentList)
        {
            Console.WriteLine(item.Name);
        }

        // OrderBy()
        Console.WriteLine();
        Console.WriteLine("**** OrderBy ****");
        studentList = _context.Students.OrderBy(x => x.StudentId).ToList();
        foreach (var item in studentList)
        {
            Console.WriteLine(item.StudentId + "-" + item.Name + " " + item.Surname);
        }

        // OrderByDescending()
        Console.WriteLine();
        Console.WriteLine("**** OrderByDescending ****");
        studentList = _context.Students.OrderByDescending(x => x.StudentId).ToList();
        foreach (var item in studentList)
        {
            Console.WriteLine(item.StudentId + "-" + item.Name + " " + item.Surname);
        }

        // Anonymous Object Result
        Console.WriteLine();
        Console.WriteLine("**** Anonymous Object Result ****");
        var anonymousObj = _context.Students
            .Where(x => x.ClassId == 2)
            .Select(x => new {
                Id = x.StudentId,
                FullName = x.Name + " " + x.Surname,
            });
        foreach (var item in anonymousObj)
        {
            Console.WriteLine(item.Id + "- " + item.FullName);
        }
    }
}

