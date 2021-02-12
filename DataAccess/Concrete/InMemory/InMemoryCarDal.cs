using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=1996, DailyPrice= 120, Description= " Toplam km sınırı 800km" },
                new Car{CarId=2, BrandId=2, ColorId=3, ModelYear=2010, DailyPrice= 150, Description= " Toplam km sınırı 750km" },
                new Car{CarId=3, BrandId=3, ColorId=4, ModelYear=2000, DailyPrice= 145, Description= " Toplam km sınırı 800km" },
                new Car{CarId=4, BrandId=4, ColorId=2, ModelYear=2018, DailyPrice= 180, Description= " Toplam km sınırı 700km" },
                new Car{CarId=5, BrandId=5, ColorId=5, ModelYear=1998, DailyPrice= 120, Description= " Toplam km sınırı 800km" },
                new Car{CarId=6, BrandId=2, ColorId=2, ModelYear=2010, DailyPrice= 135, Description= " Toplam km sınırı 750km" },
                new Car{CarId=7, BrandId=1, ColorId=1, ModelYear=2010, DailyPrice= 135, Description= " Toplam km sınırı 900km" }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
