namespace Polus.Task6.Core
{
    public abstract class CarBase
    {
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
            BodyType = bodyType;
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;
        }

        public double Move()
        {
            return 0;
        }
    }
}
