using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}