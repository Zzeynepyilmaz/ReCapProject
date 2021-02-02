using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.ModelYear + " Model ," + cars.DailyPrice + " TL," + cars.Description);
            }
            Console.WriteLine("---------------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine("---------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }    
    }
}
