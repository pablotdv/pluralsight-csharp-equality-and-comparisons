using System;
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

    class FoodItemEqualityComparer : EqualityComparer<FoodItem>
    {
        private static FoodItemEqualityComparer _instance = new FoodItemEqualityComparer();
        public static FoodItemEqualityComparer Instance { get { return _instance; } }
        private FoodItemEqualityComparer()
        {

        }
        public override bool Equals(FoodItem x, FoodItem y)
        {
            return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant() && x.Group == y.Group;
        }

        public override int GetHashCode(FoodItem obj)
        {
            return obj.Name.ToUpperInvariant().GetHashCode() ^ obj.Group.GetHashCode();
        }
    }
}
