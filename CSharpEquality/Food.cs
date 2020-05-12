namespace CSharpEquality
{
    public class Food
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        public Food(string name, FoodGroup group)
        {
            _name = name;
            _group = group;
        }

        public override string ToString()
        {
            return $"{_name} ({_group})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Food rhs = obj as Food;
            return _name == rhs._name && this._group == rhs._group;
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        public static bool operator ==(Food x, Food y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
        }
    }
}
