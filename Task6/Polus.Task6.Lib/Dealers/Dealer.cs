
using Polus.Task6.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polus.Task6.Lib.Dealers
{
    public class Dealer : IDealer
    {
        private readonly List<CarBase> _cars;

        public string DealerName { get; }

        public Dealer(string dealerName)
        {
            _cars = new List<CarBase>();
            DealerName = dealerName;
        }
        
        public void BuyCar(CarBase car)
        {
            _cars.Add(car);
        }

        public void SellCar(CarBase car)
        {
            if (car == null)
                throw new ArgumentException("Car is null!");
            if (!_cars.Contains(car))
                throw new ArgumentException("Car not found!");
            _cars.ToList().Remove(car);
        }

        public IEnumerable<CarBase> GetAllCars()
        {
            return _cars;
        }
    }
}
