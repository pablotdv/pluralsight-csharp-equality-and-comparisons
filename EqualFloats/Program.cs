using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            float six = 6.0000000F;
            float nearlySix = 6.0000001F;

            Console.WriteLine(six.Equals(nearlySix));
        }
    }
}
