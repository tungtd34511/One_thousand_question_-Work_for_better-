using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class A : IA
    {
        public int b { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task AB()
        {
            throw new NotImplementedException();
        }
    }
}
