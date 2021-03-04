using Polus.Task6.Core;

namespace Polus.Task6.Lib.Cars
{
    public class Car : CarBase
    {
        public Car(IBodyType bodyType, IBrand brand, IModel model, IColor color, decimal price)
             :base(bodyType, brand, model, color, price)
        {
            
        }

        public override string ToString()
        {
            var description = $"Легковой автомобиль {Brand.BrandName} {Model.ModelName} {Model.ModelGeneration} поколения, " +
                $"{BodyType.BodyName}, Колесная формула: {BodyType.TypeOfDrive}, Цвет: {Color.ColorName}, Цена: {Price} рублей";
            return description;
        }
    }
}
