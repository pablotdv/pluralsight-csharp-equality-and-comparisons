using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "apple", "orange", "pineapple" };
            string[] arr2 = { "apple", "pear", "Pineapple" };

            var arrayEq = (IStructuralEquatable)arr1;
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structEqual);

            var arrayComp = (IStructuralComparable)arr1;
            int structComp = arrayComp.CompareTo(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structComp);

            Console.WriteLine();
            Console.WriteLine();


            FoodItem beetroot = new FoodItem("beetroot", FoodGroup.Vegetables);
            FoodItem pickletdBeetroot = new FoodItem("beetroot", FoodGroup.Sweets);
            
            var eqComparer = FoodNameEqualityComparer.Instance;
            bool equals = eqComparer.Equals(beetroot, pickletdBeetroot);

            Console.WriteLine("Equals? " + equals.ToString());
            Console.WriteLine(eqComparer.GetHashCode(beetroot));
            Console.WriteLine(eqComparer.GetHashCode(pickletdBeetroot));

            Console.WriteLine();
            Console.WriteLine();

            var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
            names.Add("apple");
            names.Add("pear");
            names.Add("pineapple");
            names.Add("Apple");
            foreach (var item in names)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine();

            //var foodItems = new HashSet<FoodItem>(EqualityComparer<FoodItem>.Default);
            var foodItems = new HashSet<FoodItem>(FoodItemEqualityComparer.Instance);
            //var foodItems = new HashSet<FoodItem>();
            foodItems.Add(new FoodItem("apple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pear", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pineapple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("Apple", FoodGroup.Fruit));
            foreach (var item in foodItems)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine();
            Food[] list = {
                new Food("apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new CookedFood("baked", "apple", FoodGroup.Fruit),
            };
            SortAndShowList(list);

            Food[] list2 = {
                new CookedFood("baked", "apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit),
            };
            Console.WriteLine();
            SortAndShowList(list2);
        }

        private static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
