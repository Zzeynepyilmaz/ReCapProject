﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.CarId
                             join customer in context.Customers on rental.CustomerId equals customer.UserId
                             join user in context.Users on customer.UserId equals user.Id
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarDescription = car.Description,
                                 CarBrand = brand.BrandName,
                                 CarModel = car.ModelYear,
                                 CompanyName = customer.CompanyName,
                                 CustomerFirstName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate == null ? (DateTime?)null : rental.ReturnDate
                             };
                return result.ToList();
            }
        }   
    }
}
