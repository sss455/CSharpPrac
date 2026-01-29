using System.Text;

namespace SelfCSharp.Chap03
{
    internal class CompareStringBuilder
    {
        static void Main(string[] args)
        {
            var builder1 = new StringBuilder("あいう");
            var builder2 = new StringBuilder("あいう");
            Console.WriteLine(builder1 == builder2);
            Console.WriteLine(builder1.Equals(builder2));
        }
    }
}
