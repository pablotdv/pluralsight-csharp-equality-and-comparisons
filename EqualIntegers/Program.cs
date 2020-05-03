using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int threeAgain = 3;
            bool intCmp = (three == threeAgain);
            Console.WriteLine($"compare ints:           {intCmp}");

            bool objCmp = ((object)three == (object)threeAgain);
            Console.WriteLine($"compare objects:        {objCmp}");

            bool itCmp = ((IComparable<int>)three == (IComparable<int>)threeAgain);
            Console.WriteLine($"compare interfaces:     {itCmp}");
        }
    }
}
