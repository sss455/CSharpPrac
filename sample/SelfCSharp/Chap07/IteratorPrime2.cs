using System.Collections;

namespace SelfCSharp.Chap07
{
    internal class PrimeList : IEnumerable<int>
    {
        int max = 2;

        public PrimeList(int max)
        {
            this.max = max;
        }

        public IEnumerator<int> GetEnumerator()
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

            if (this.max < Min)
            {
                Console.WriteLine("引数maxは2以上の値を指定してください。");
                yield break;
            }

            for (var num = Min; num <= this.max; num++)
            {
                if (IsPrime(num))
                {
                    yield return num;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    internal class IteratorPrime2
    {
        static void Main(string[] args)
        {
            var list = new PrimeList(100);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}

