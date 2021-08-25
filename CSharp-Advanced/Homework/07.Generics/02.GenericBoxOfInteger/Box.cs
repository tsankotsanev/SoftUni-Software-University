namespace _02.GenericBoxOfInteger
{
    class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
