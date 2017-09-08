using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;

            try
            {
                b /= a;
            }

            catch(DivideByZeroException )

            {
                Console.WriteLine(a);
            }

        }
    }
}
