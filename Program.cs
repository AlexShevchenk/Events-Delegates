using System;

namespace Delegat
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.showDelegate = Show;

            Class2 class2 = new Class2();
            MyResultDelegate myResultDelegate = class2.Calc(class1.Pow, 4, 2);

            bool result = myResultDelegate(2);
            class1.showDelegate(result);
        }

        static void Show(bool value)
        {
            Console.WriteLine(value);
        }
    }

}