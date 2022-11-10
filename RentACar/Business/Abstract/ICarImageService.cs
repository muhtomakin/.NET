using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int imageId);
        IDataResult<List<CarImage>> GetByCarId(int carId);
        
    }
}