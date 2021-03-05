
using Polus.Task6.Core;

namespace Polus.Task6.Lib.Parts
{
    public class Model : IModel
    {
        public string ModelName { get; }

        public string ModelCode { get; }

        public string ModelGeneration { get; }

        public Model(string modelName, string modelGeneration = "1")
        {
            ModelName = modelName;
            ModelGeneration = modelGeneration;
            ModelCode = $"W{ModelName[0]}{modelGeneration}-{ModelName.GetHashCode()}";
        }

        public override string ToString() => $"{ModelName}";
    }
}
