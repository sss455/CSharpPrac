namespace SelfCSharp.Chap05
{
    internal class RandomBasic
    {
        static void Main(string[] args)
        {
            var rn = new Random();
            Console.WriteLine(rn.Next());
            Console.WriteLine(rn.Next(100));
            Console.WriteLine(rn.Next(100, 200));
            Console.WriteLine(rn.NextInt64());
            Console.WriteLine(rn.NextSingle());
            Console.WriteLine(rn.NextDouble());

            var data = new byte[5];
            rn.NextBytes(data);
            foreach (var b in data)
            {
                Console.WriteLine($"{b} ");
            }
        }
    }
}
