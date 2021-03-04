using Polus.Task6.Core;
using Polus.Task6.Lib.Cars;
using Polus.Task6.Lib.Parts;

namespace Polus.Task6.Lib.Factory
{
    public class SUVFactory : MashinFactoryBase
    {
        public SUVFactory(string factoryName, string brand) : base(factoryName, brand)
        {
            carType = new CarType(CarTypes.Bus);
        }

        public override CarBase Create(BodyNames bodyName, int doors, int wheels, int seats, TypesOfDrive typesOfDrive,
                                       string model, string generation, Colors color,
                                       double weght, double carrying, decimal price)
        {
            body = new BodyType(bodyName, doors, wheels, seats, typesOfDrive);
            this.model = new Model(model);
            this.color = new Color(color);
            this.price = price;

            CarBase car = new Suv(body, Brand, this.model, this.color, price)
            {
                CarType = carType,
                Weght = weght,
                Сarrying = carrying
            };
            return car;
        }
    }
}
