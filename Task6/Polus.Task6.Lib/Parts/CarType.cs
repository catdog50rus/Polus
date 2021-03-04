
using Polus.Task6.Core;

namespace Polus.Task6.Lib.Parts
{
    public class CarType : ICarType
    {
        public string TypeName { get; }
        public CarType(CarTypes typeName)
        {
            TypeName = typeName.ToString();
        }
    }

    public enum CarTypes
    {
        None,
        Car,
        Suv,
        Bus,
        Truck
    }
}
