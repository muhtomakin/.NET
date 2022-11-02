using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new InMemoryProductDal());
        foreach(var product in productManager.GetAll())
        {
            Console.WriteLine(product.CategoryId);
        }
    }
}
