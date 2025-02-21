namespace Course.Entities
{
    class PrintService
    {
        public int[] _value = new int[10];
        public int _count = 0;

        public void AddValue(int value)
        {
            _value[_count] = value;
            _count++;
        }
        public int First()
        {
            return _value[0];
        }
        public void Print()
        {
            Console.WriteLine("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.WriteLine(_value[i] + ",");
            }
            if (_count > 0)
            {
                Console.WriteLine(_value[_count - 1]);
            }
            Console.WriteLine("]");
            Console.WriteLine();
        }
    }
}
