using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public delegate bool MyResultDelegate(int value);

    public class Class2
    {
        private int result;

        public MyResultDelegate Calc(Func<int, int, int> powDelegate, int a, int b)
        {
            result = powDelegate(a, b);
            return Result;
        }

        public bool Result(int a)
        {
            int remainder = result % a;
            if (remainder == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
