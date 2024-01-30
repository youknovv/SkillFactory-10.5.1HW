using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10._5._1HW
{
    internal class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}
