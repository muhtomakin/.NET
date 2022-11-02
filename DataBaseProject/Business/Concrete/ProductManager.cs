using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    IProductDal _productDal;
    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }
}