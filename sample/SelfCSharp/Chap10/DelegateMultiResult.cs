namespace SelfCSharp.Chap10.Delegate3
{
    delegate string OutputProcess(string str);

    internal class DelegateMultiResult
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }

        static string AddQuote(string data)
        {
            return $"［{data}］";
        }

        static string Front4(string data)
        {
            return data.Substring(0, 4);
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dr = new DelegateMultiResult();
            OutputProcess proc = AddQuote;
            proc += Front4;
            dr.ArrayWalk(data, proc);
        }
    }
}
