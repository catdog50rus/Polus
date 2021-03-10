using System.Collections;
using System.Collections.Generic;

namespace Polus.Task1
{
    public interface IRepository
    {
        Dictionary<string,string[]> GetData(string pathDir, int length);
    }
}
