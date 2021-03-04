using Polus.Task6.Core;

namespace Polus.Task6.Lib.Cars
{
    public class Bus : CarBase
    {
        public Bus(IBodyType bodyType, IBrand brand, IModel model, IColor color, decimal price)
             : base(bodyType, brand, model, color, price)
        {

        }

        public override string ToString()
        {
            var description = $"Автобус {Brand.BrandName} {Model.ModelName} {Model.ModelGeneration} поколения, " +
                $"Посадочных мест {BodyType.NumberOfSeats}, включая водителей, Колесная формула: {BodyType.TypeOfDrive}, Цвет: {Color.ColorName}, Цена: {Price} рублей";
            return description;
        }
    }
}
