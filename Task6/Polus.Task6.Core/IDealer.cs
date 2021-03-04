using System.Collections.Generic;

namespace Polus.Task6.Core
{
    public interface IDealer
    {
        void BuyCar(CarBase car);

        void SellCar(CarBase car);
        IEnumerable<CarBase> GetAllCars();
    }
}
