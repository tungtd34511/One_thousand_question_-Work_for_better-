using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFB_1_What_is_Constructor
{
    public class Demo
    {
        private int _count;

        public Demo(int count)
        {
            _count = count;
            Console.Write(Count);
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
    }
}
