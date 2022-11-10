using Entities.Concrete;
using System.Collections.Generic;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        
    }
}