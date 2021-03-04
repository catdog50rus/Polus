using Polus.Task6.Core;
using Polus.Task6.Lib.Cars;
using Polus.Task6.Lib.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polus.Task6.Lib.Factory
{
    public class BusFactory : MashinFactoryBase
    {
        public BusFactory(string factoryName, string brand) : base(factoryName, brand)
        {
            carType = new CarType(CarTypes.Bus);
        }

        public override CarBase Create(BodyNames bodyName, int doors, int wheels, int seats, TypesOfDrive typesOfDrive,
                                       string model, string generation, Colors color,
                                       double weght, double carrying, decimal price)
        {
            this.body = new BodyType(bodyName, doors, wheels, seats + 2, typesOfDrive);
            this.model = new Model(model);
            this.color = new Color(color);
            this.price = price;

            CarBase car = new Bus(body, Brand, this.model, this.color, price) 
            {
                CarType = carType,
                Weght = weght,
                Сarrying = carrying
            };
            return car;
        }
    }
}
