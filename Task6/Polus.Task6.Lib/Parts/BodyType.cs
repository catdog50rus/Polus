using Polus.Task6.Core;

namespace Polus.Task6.Lib.Parts
{
    public class BodyType : IBodyType
    {
        public string BodyName { get; }

        public int NumberOfDoors { get; }

        public int NumberOfWheels { get; }

        public int NumberOfSeats { get; }

        public string TypeOfDrive { get; }

        public BodyType(BodyNames bodyName, int numberOfDoors, int numberOfWheels, int numberOfSeats, TypesOfDrive typeOfDrive)
        {
            BodyName = bodyName.ToString();
            NumberOfDoors = numberOfDoors;
            NumberOfWheels = numberOfWheels;
            NumberOfSeats = numberOfSeats;
            TypeOfDrive = $"{typeOfDrive}x{numberOfWheels}";       
        }
    }

    public enum BodyNames
    {
        None,
        Sedan,
        Coupe,
        Convertible,
        Hatchback,
        Wagon,
        Pickup,
        Minivan,
        Bus
    }

    public enum TypesOfDrive
    {
        None,
        Mono2,
        Full4,
        Full6
    }
}
