using System;
using System.Collections.Generic;

namespace CSharpEquality
{
    public class FoodNameComparer : IComparer<Food>
    {
        public int Compare(Food x, Food y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }
}
