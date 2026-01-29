namespace SelfCSharp.Chap10
{
    internal class LambdaMember
    {
        private int _value;

        LambdaMember() => Console.WriteLine("constructor");

        public int Value
        {
            get => this._value;
            set => this._value = value;
        }

        public DateTime Current => DateTime.Now;

        public int this[int index] => this.Value * index;

        public int Calculate() => this.Value * this.Value;

        public static bool operator true(LambdaMember e) => e.Value == 0;
        public static bool operator false(LambdaMember e) => e.Value != 0;

        static void Main(string[] args)
        {
            var lm = new LambdaMember
            {
                Value = 2
            };
            Console.WriteLine(lm.Current);
            Console.WriteLine(lm[3]);
            Console.WriteLine(lm.Calculate());

            if (lm)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
