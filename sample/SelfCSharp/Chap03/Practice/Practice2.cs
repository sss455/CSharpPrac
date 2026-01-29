using System.Text;

namespace SelfCSharp.Chap03.Practice
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = x;
            x -= 3;

            var builder1 = new StringBuilder("abc");
            var builder2 = builder1;
            builder1.Append("def");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(builder1);
            Console.WriteLine(builder2);

        }
    }
}
