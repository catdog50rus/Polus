using System;

namespace Polus.Task5
{
    class Program
    {
        static void Main()
        {
            NumToBin convert = new NumToBin();
            string result = convert.GetNums(short.MaxValue-20000);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        
    }
}
