using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, NorthwindContext>, ICarImageDal
    {

    }
}