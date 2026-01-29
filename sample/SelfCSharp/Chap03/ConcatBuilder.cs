using System.Text;

namespace SelfCSharp.Chap03
{
    internal class ConcatBuilder
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            var builder = new StringBuilder();
            //var builder = new StringBuilder(1000);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append("いろは");
            }
            var result = builder.ToString();
            var end = DateTime.Now;
            Console.WriteLine(end.Ticks - start.Ticks);
        }
    }
}
