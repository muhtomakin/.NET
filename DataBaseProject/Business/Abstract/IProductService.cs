using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract;

public class IProductService
{
    List<Product> GetAll();
}