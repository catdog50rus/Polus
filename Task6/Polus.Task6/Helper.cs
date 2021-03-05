using Polus.Task6.Core;
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

        public static void GetCarCard(this CarBase car)
        {
            Console.Clear();
            Console.WriteLine($"Технические характеристики автомобиля: {car.Brand} {car.Model}");
            Console.WriteLine();
            
            Console.WriteLine($"VIN: {car.VIN}");
            Console.WriteLine($"Тип: {car.CarType.TypeName}");
            Console.WriteLine($"Марка: {car.Brand.BrandName}");
            Console.WriteLine($"Модель: {car.Model}, Код модели: {car.Model.ModelCode}");
            Console.WriteLine($"Кузов: {car.BodyType.BodyName}");
            Console.WriteLine($"Число мест, включая водителя: {car.BodyType.NumberOfSeats}");
            Console.WriteLine($"Колесная формула: {car.BodyType.TypeOfDrive}");
            Console.WriteLine($"Цвет: {car.Color.ColorName}, Код: {car.Color.ColorCode}");
            Console.WriteLine($"Грузоподъемность: {car.Сarrying}");
            Console.WriteLine($"Полная масса: {car.Weght}");

            Console.WriteLine();

        }
    }
}
