using System;

namespace RefTypeEquality
{
    public sealed class CookedFood : Food, IEquatable<CookedFood>
    {
        private string _cookingMethod;
        public string CookingMethod { get { return _cookingMethod; } }

        public CookedFood(string cookingMethod, string name, FoodGroup group)
            : base(name, group)
        {
            _cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return $"{_cookingMethod} {Name}";
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;
            CookedFood rhs = (CookedFood)obj;
            return _cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _cookingMethod.GetHashCode();
        }

        public bool Equals(CookedFood other)
        {
            if (!base.Equals(other))
                return false;
            return _cookingMethod == other._cookingMethod;
        }

        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }
    }
}
