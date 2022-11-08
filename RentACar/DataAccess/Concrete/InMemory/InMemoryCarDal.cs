using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=2, ColorId=1, ModelYear=2017, Description="Gasoline Manual", DailyPrice=1200, ModelName="Audi"},
                new Car{CarId=2, BrandId=1, ColorId=1, ModelYear=2020, Description="Diesel Automatic", DailyPrice=2000, ModelName="Volswagen"},
                new Car{CarId=3, BrandId=1, ColorId=3, ModelYear=2019, Description ="Gasoline Automatic", DailyPrice =1900, ModelName="BMW"},
                new Car{CarId=4, BrandId=3, ColorId=2, ModelYear=2022, Description="Diesel Automatic", DailyPrice=2500, ModelName="Mercedes-Benz"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelName = car.ModelName;
            updatedCar.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}