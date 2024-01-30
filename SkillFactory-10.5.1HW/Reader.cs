using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10._5._1HW
{
    internal static class Reader
    {
        internal static double Read()
        {
            Console.WriteLine("Введите слагаемое: ");
            try
            {
                bool res = double.TryParse(Console.ReadLine(), out double x);
                if (res)
                    return x;
                else

                    throw new MyException("Неверный формат ввода числа");


            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
