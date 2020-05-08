using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompareStringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current culture is " + Thread.CurrentThread.CurrentCulture);
            string str1 = "apple";
            string str2 = "PINEAPPLE";
            string str3 = "Apple";

            // U+00DF is eszett
            string str4 = "Stra\u00dfe";
            string str5 = "Strasse";

            // a-umlaut is U+00E4
            // umlaut (combining diaeresis) is U+0308
            string str6 = "erkl\u00e4ren";
            string str7 = "erkla\u0308ren";
            string str8 = "erklären";

            DisplayAllComparisons(str1, str2);
            Console.WriteLine();
            DisplayAllComparisons(str1, str3);
            Console.WriteLine();
            DisplayAllComparisons(str4, str5);
            Console.WriteLine();
            DisplayAllComparisons(str6, str7);
            DisplayAllComparisons(str8, str6);
            DisplayAllComparisons(str8, str7);

        }

        static void DisplayAllComparisons(string str1, string str2)
        {
            DisplayComparison(str1, str2, StringComparison.Ordinal);
            DisplayComparison(str1, str2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.InvariantCulture);
            DisplayComparison(str1, str2, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine();
            DisplayComparison(str1, str2, StringComparison.CurrentCulture);
            DisplayComparison(str1, str2, StringComparison.CurrentCultureIgnoreCase);
        }

        static void DisplayComparison(string str1, string str2, StringComparison comparison)
        {
            int result = string.Compare(str1, str2, comparison);
            Console.WriteLine("{0} {1} {2}     ({3} {4})", str1, GetCompareSymbol(result), str2, result, comparison);
        }

        static string GetCompareSymbol(int compareResult)
        {
            if (compareResult == 0)
                return "==";

            if (compareResult < 0)
                return "< ";

            return "> ";
        }
    }
}
