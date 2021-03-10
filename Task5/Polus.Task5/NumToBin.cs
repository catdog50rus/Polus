using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polus.Task5
{
    public class NumToBin
    {


        public string GetNums(short data)
        {
            StringBuilder sb = new StringBuilder();

            var bin = Convert.ToString(data, 2);
            Console.WriteLine(bin);

            var l = 15-bin.Length;
            int shift = l, startIndex = 15-2+l;

            for (int i = 0; i < l; i++)
            {
                sb.Append('0');
            }
            

            var A = ConvertToBin(data, shift + 13, startIndex - 13, 2);
            Console.WriteLine($"A: {A}");

            var B = ConvertToBin(data, shift + 8, startIndex - 10, 4);
            Console.WriteLine($"B: {B}");

            var C = ConvertToBin(data, shift + 6, startIndex - 5, 1);
            Console.WriteLine($"C: {C}");

            var D = ConvertToBin(data, shift + 5, startIndex - 4, 1);
            Console.WriteLine($"D: {D}");

            var E = ConvertToBin(data, shift + 4, startIndex - 3, 1);
            Console.WriteLine($"E: {E}");

            var F = ConvertToBin(data, shift + 3, startIndex - 2, 1);
            Console.WriteLine($"F: {F}");

            var G = ConvertToBin(data, shift, startIndex, 2);
            Console.WriteLine($"G: {G}");
            return null;
        }


        private string ConvertToBin(short data, int shift, int startIndex, int length)
        {
            if (startIndex < 0)
                return "";
            var num = data >> shift;
            return Convert.ToString(data, 2).Substring(startIndex, length);
        }
    }
}
