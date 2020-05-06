using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "apple";
            string str2 = string.Copy(str1);
            DisplayWhetherArgsEqual(str1, str2);
        }

        static void DisplayWhetherArgsEqual<T>(T x, T y)
            where T: class
        {
            Console.WriteLine("Equal? " + (x == y));
            Console.WriteLine("Equal? " + (x.Equals(y)));
        }
    }
}
