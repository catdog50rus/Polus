namespace Polus.Task6.Core
{
    public interface IBodyType
    {
        string BodyName { get; }
        int NumberOfDoors { get; }
        int NumberOfWheels { get; }
        int NumberOfSeats { get; }
        string TypeOfDrive { get; }
    }
}
