using Polus.Task6.Core;
using Polus.Task6.Lib.Dealers;
using Polus.Task6.Lib.Factory;
using Polus.Task6.Lib.Parts;
using System;

namespace Polus.Task6
{
    class Program
    {
        static void Main()
        {
            Dealer dealer = new Dealer("Фаворит моторс");

            MashinFactoryBase suzukiMotors = new CarsFactory("Suzuki Motors", "Suzuki");
            MashinFactoryBase vwGroupe = new SUVFactory("VW Motors SUV", "VW");
            MashinFactoryBase man = new BusFactory("Man Neoplan", "Man");

            CarBase[] cars = new CarBase[]
            {
                suzukiMotors.Create(BodyNames.Sedan, 4, 4, 5, TypesOfDrive.Mono2,
                                    "SX-4", "1", Colors.Black, 
                                    1250d, 800, 1_200_000),
                suzukiMotors.Create(BodyNames.Hatchback, 5, 4, 5, TypesOfDrive.Full4,
                                    "SX-4", "1", Colors.Yellow, 
                                    1280d, 850d ,1_200_000),
                vwGroupe.Create(BodyNames.Wagon, 5, 4, 5, TypesOfDrive.Full4,
                                "Tuareg FX", "2", Colors.White, 
                                2300d, 120d, 4_500_000),
                man.Create(BodyNames.Bus, 1, 6, 40, TypesOfDrive.Full4,
                           "Neoplan CityLiner", "1", Colors.Black, 
                           5_000d, 8_000d, 15_000_000)
            };
            foreach (var car in cars)
            {
                dealer.BuyCar(car);
            }

            dealer.ShowCars();

            Console.WriteLine();
            Console.ReadKey();

            var dealersCars = dealer.GetAllCars();
            foreach (var car in dealersCars)
            {
                car.GetCarCard();
                Console.ReadKey();
            }

        }

        
    }
}
