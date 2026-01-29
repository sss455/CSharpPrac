namespace SelfCSharp.Chap10
{
    internal class DelegateNoUse
    {
        void ArrayWalk(string[] data)
        {
            foreach (var value in data)
            {
                Console.WriteLine($"［{value}］");
            }
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };
            var nu = new DelegateNoUse();
            nu.ArrayWalk(data);
        }
    }
}
