using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10._5._1HW
{
    class Program
    {
        public static void Main(string[] args)
        {
            ILogger Logger = new Logger();
            Summ summ = new Summ(Reader.Read(), Reader.Read());
            if (summ.X == 0 || summ.Y == 0)
            {
                Logger.Error();
                Console.WriteLine("Рассчитать сумму невозможно");
            }
            else
            {
                Logger.Event();
                Console.WriteLine($"Результат сложения: {summ.Sum(summ.X, summ.Y)}");
            }
        }
    }
}
