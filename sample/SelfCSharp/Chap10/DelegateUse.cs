namespace SelfCSharp.Chap10
{
    delegate void OutputProcess(string str);

    internal class DelegateUse
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

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var du = new DelegateUse();
            OutputProcess proc = AddQuote;
            du.ArrayWalk(data, proc);
            //du.ArrayWalk(data, AddQuote);
        }
    }
}

