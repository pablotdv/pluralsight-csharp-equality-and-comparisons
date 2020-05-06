using System;

namespace FoodEqualsButton
{
    public class Food : IEquatable<Food>
    {
        private string _name;
        public string Name { get { return _name; } }
        public Food(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        public bool Equals(Food other)
        {
            return base.Equals(other);
        }
    }
}