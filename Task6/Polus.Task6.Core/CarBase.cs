using System;

namespace Polus.Task6.Core
{
    public abstract class CarBase
    {
        public string VIN { get; }
        public ICarType CarType { get; set; }
        public IBodyType BodyType { get; set; }
        public IBrand Brand { get; set; }
        public IModel Model { get; set; }
        public IColor Color { get; set; }
        public decimal Price { get; set; }
        public int NumberOfSeats { get; set; }
        public double Сarrying { get; set; }
        public double Weght { get; set; }

        public CarBase(IBodyType bodyType, IBrand brand, IModel model, IColor color, decimal price)
        {
            VIN = $"{brand.BrandName.ToUpper()[0]}" +
                  $"{bodyType.BodyName.ToUpper()[0]}" +
                  $"{Guid.NewGuid():N}";
            BodyType = bodyType;
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;
        }

    }
}
