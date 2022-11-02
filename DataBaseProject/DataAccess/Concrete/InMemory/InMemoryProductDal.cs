using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal : IProductDal
{
    List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product> {
            new Product{ProductId = 1, CategoryId = 1, ProductName = "Apple", UnitPrice = 15, UnitsInStock = 15},
            new Product{ProductId = 2, CategoryId = 1, ProductName = "Apple", UnitPrice = 15, UnitsInStock = 15},
            new Product{ProductId = 3, CategoryId = 2, ProductName = "Apple", UnitPrice = 15, UnitsInStock = 15},
            new Product{ProductId = 4, CategoryId = 2, ProductName = "Apple", UnitPrice = 15, UnitsInStock = 15},
            new Product{ProductId = 5, CategoryId = 4, ProductName = "Apple", UnitPrice = 15, UnitsInStock = 15},
        };
    }
    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        Product updatedProduct = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
        updatedProduct.ProductName = product.ProductName;
        updatedProduct.CategoryId = product.CategoryId;
        updatedProduct.UnitPrice = product.UnitPrice;
        updatedProduct.UnitsInStock = product.UnitsInStock;
    }

    public void Delete(Product product)
    {
        Product deletedProduct = _products.SingleOrDefault(x => x.ProductId == product.ProductId);

        _products.Remove(deletedProduct);
    }

    public List<Product> GetAll()
    {
        return _products;
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _products.Where(x => x.CategoryId == categoryId).ToList();
    }

}