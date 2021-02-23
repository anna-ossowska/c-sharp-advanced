namespace Summary
{
    // Nullable class is actually a part of .NET Framework, but I create it here for the learning purposes
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}