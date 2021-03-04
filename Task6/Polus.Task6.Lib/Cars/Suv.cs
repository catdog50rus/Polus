using Polus.Task6.Core;

namespace Polus.Task6.Lib.Cars
{
    public class Suv : CarBase
    {
        public Suv(IBodyType bodyType, IBrand brand, IModel model, IColor color, decimal price)
             : base(bodyType, brand, model, color, price)
        {

        }

        public override string ToString()
        {
            var description = $"Внедорожный автомобиль {Brand.BrandName} {Model.ModelName} {Model.ModelGeneration} поколения, " +
                $"{BodyType.BodyName}, Колесная формула: {BodyType.TypeOfDrive}, Цвет: {Color.ColorName}, Цена: {Price} рублей";
            return description;
        }
    }
}
