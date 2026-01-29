namespace SelfCSharp.Chap07
{
    internal class PrimeNumber
    {
        public IEnumerable<int> GetPrimes(int max)
        {
            bool IsPrime(int value)
            {
                var prime = true;
                for (var i = 2; i <= Math.Floor(Math.Sqrt(value)); i++)
                {
                    if (value % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                return prime;
            }

            const int Min = 2;

            if (max < Min)
            {
                Console.WriteLine("引数maxは2以上の値を指定してください。");
                yield break;
            }

            for (var num = Min; num <= max; num++)
            {
                if (IsPrime(num))
                {
                    yield return num;
                }
            }
        }
    }

    internal class IteratorPrime
    {
        static void Main(string[] args)
        {
            var p = new PrimeNumber();
            foreach (var value in p.GetPrimes(100))
            {
                Console.WriteLine(value);
            }
        }
    }
}
