using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {

    }
}