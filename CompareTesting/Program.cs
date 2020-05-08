using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string.Compare("apple", "pear", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
