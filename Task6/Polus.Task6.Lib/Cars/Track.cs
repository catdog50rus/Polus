
using Polus.Task6.Core;

namespace Polus.Task6.Lib.Cars
{
    public class Track : CarBase
    {
        public Track(IBodyType bodyType, IBrand brand, IModel model, IColor color, decimal price)
             : base(bodyType, brand, model, color, price)
        {

        }

        public override string ToString()
        {
            var description = $"Грузовик {Brand.BrandName} {Model.ModelName} {Model.ModelGeneration} поколения, " +
                $"Грузоподъемность: {Сarrying}кг, Число мест, включая водителя: {BodyType.NumberOfSeats}, Колесная формула: {BodyType.TypeOfDrive}, Цвет: {Color.ColorName}, Цена: {Price} рублей";
            return description;
        }
    }
}
