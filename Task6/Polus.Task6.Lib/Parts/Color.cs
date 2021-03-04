using Polus.Task6.Core;

namespace Polus.Task6.Lib.Parts
{
    public class Color : IColor
    {
        public string ColorName { get; }

        public string ColorCode { get; }

        public Color(Colors color)
        {
            ColorName = color.ToString();
            ColorCode = $"C{ColorName[0]}Y-{ColorName.GetHashCode()}";
        }
    }

    public enum Colors
    {
        None, White, Blue, Yellow, Green, Black
    }
}
