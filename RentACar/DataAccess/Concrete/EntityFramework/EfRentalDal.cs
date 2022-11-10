using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, NorthwindContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join a in context.Colors on c.ColorId equals a.ColorId
                             join r in context.Rentals on c.CarId equals r.CarId
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorName = a.ColorName,
                                 ModelName = c.ModelName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}