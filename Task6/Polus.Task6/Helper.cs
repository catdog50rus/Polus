using Polus.Task6.Lib.Dealers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polus.Task6
{
    public static class Helper
    {
        public static void ShowCars(this Dealer dealer)
        {
            Console.WriteLine($"Перечень автомобилей в наличии у автодилера {dealer.DealerName}");
            Console.WriteLine();

            var cars = dealer.GetAllCars();
            if (!cars.Any()) 
            {
                Console.WriteLine("Автомобилей в наличии нет!");
                return;
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

                
            


        }
    }
}
