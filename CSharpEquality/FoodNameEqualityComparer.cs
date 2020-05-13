using System.Collections.Generic;

namespace CSharpEquality
{
    internal class FoodNameEqualityComparer : EqualityComparer<FoodItem>
    {
        private static FoodNameEqualityComparer _instance = new FoodNameEqualityComparer();
        public static FoodNameEqualityComparer Instance { get { return _instance; } }
        private FoodNameEqualityComparer()
        {

        }

        public override bool Equals(FoodItem x, FoodItem y)
        {
            return x.Name == y.Name;
        }

        public override int GetHashCode(FoodItem obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
