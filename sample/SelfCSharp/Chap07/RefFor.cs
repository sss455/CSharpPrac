namespace SelfCSharp.Chap07
{
    internal class RefFor
    {
        static void Main(string[] args)
        {
            var result = 0;
            var sum = 0;

            for (ref var i = ref result; i < 100; i++)
            {
                sum += i;
                if (sum > 1000)
                {
                    break;
                }
            }

            Console.WriteLine($"合計が1000を越えるのは、1～{result}を加算したときです。");
        }
    }
}
