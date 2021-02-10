using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

        }
        public static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarDetails())
            {
                Console.Write(c.BrandName + "   "  + c.ModelYear + "   " + c.ColorName + "   " + c.DailyPrice);
                Console.WriteLine();
                Console.ReadLine();
            }
        }



        public static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetCarsByColorId(1))
            {
                Console.WriteLine(color.ColorName);
                Console.ReadLine();
            }
        }

        public static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(brand.BrandName);
                Console.ReadLine();
            }
        }
    }
}
