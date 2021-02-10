using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from car in context.Cars
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 CarName = car.Descriptions,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
