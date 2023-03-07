using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public delegate void MyDelegate(bool value);

    public class Class1
    {
        public MyDelegate showDelegate;

        public int Pow(int a, int b)
        {
            return a * b;
        }
    }

}