using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10._5._1HW
{
    internal class Logger : ILogger
    {
        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Event()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
