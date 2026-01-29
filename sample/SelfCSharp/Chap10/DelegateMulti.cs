namespace SelfCSharp.Chap10.Delegate2
{
    delegate void OutputProcess(string str);

    internal class DelegateMulti
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            Console.WriteLine($"［{data}］");
        }

        static void Front4(string data)
        {
            Console.WriteLine(data.Substring(0, 4));
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dm = new DelegateMulti();
            OutputProcess? proc = AddQuote;
            proc += Front4;
            //dm.ArrayWalk(data, proc);

            proc -= Front4;
            dm.ArrayWalk(data, proc!);
        }
    }
}
