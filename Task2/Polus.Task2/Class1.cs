using System;
using System.Linq;
/*
 * 2. Отрефакторите код. Какие возможны ваши действия в разных ситуациях.
 * if (a == 'a' || a == 'b' || a == '1' || a == '6' || ..................)
 * {
 * }
 */


namespace Polus.Task2
{
    public class Class1
    {
        private char[] dict = new char[] { 'a', 'b', '1', '6' };

        void Method(char a)
        {
            //Вариант 1
            if (dict.Contains(a))
            {
                //.....
            }
            //Вариант 2
            if (!dict.Contains(a))
            {
                //.....
            }

            //и т.д.
            
        }
    }
}
