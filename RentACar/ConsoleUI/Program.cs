using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

class Program
{
    static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach(var car in carManager.GetAll())
        {
            Console.WriteLine(car.ModelName);
        }

    } 
}