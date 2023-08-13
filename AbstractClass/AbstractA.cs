using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AbstractA
    {
        public int MyProperty { get; set; }
        public void Go()
        {
            Console.WriteLine("skmsks");
        }
        public abstract void HelpMe();
    }
}
