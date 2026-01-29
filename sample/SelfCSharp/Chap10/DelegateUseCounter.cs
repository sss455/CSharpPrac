namespace SelfCSharp.Chap10.Delegate
{
    delegate void OutputProcess(string str);

    internal class DelegateUseCounter
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegateUseCounter();
            var c = new Counter();
            du.ArrayWalk(data, c.AddLength);
            Console.WriteLine(c.Result);
        }
    }

    class Counter
    {
        public int Result { get; private set; }

        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
}
