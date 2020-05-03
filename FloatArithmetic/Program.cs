using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 5.05F;
            float y = 0.95F;

            Console.WriteLine(x + y);
            Console.WriteLine($"x + y == 6? {x + y == 6.0F}");
        }
    }
}
