﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class B : AbstractA
    {
        public override void HelpMe()
        {
            Console.WriteLine("Help!");
        }
    }
}
