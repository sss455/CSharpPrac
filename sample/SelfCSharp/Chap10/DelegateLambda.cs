namespace SelfCSharp.Chap10
{
    internal class DelegateLambda
    {
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }

        public static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var dl = new DelegateLambda();
            dl.ArrayWalk(data, (string d) =>
            {
                return $"［{d}］";
            });

            //return命令は省略可能
            //dl.ArrayWalk(data, (string d) => $"［{d}］");

            //引数の型は暗黙的に推論
            //dl.ArrayWalk(data, (d) => $"［{d}］");

            //引数が1個の場合には、引数を括るカッコも省略
            //dl.ArrayWalk(data, d => $"［{d}］");
        }
    }
}
