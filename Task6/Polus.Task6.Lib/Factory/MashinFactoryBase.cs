using Polus.Task6.Core;
using Polus.Task6.Lib.Parts;

namespace Polus.Task6.Lib.Factory
{
    public abstract class MashinFactoryBase
    {
        public string FactoryName { get; }
        public IBrand Brand { get; }
        protected ICarType carType;
        protected IBodyType body;
        protected IModel model;
        protected IColor color;
        protected decimal price;

        protected MashinFactoryBase(string factoryName, string brand)
        {
            FactoryName = factoryName;
            Brand = new Brand(brand);
        }

        public abstract CarBase Create(BodyNames bodyName, int doors, int wheels, int seats, TypesOfDrive typesOfDrive,
                                       string model, string generation, Colors color,
                                       double weght, double carrying, decimal price);


    }
}
