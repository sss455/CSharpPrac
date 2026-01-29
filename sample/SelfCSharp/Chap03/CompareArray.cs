namespace SelfCSharp.Chap03
{
    internal class CompareArray
    {
        static void Main(string[] args)
        {
            var data1 = new[] { "い", "ろ", "は" };
            var data2 = new[] { "い", "ろ", "は" };
            Console.WriteLine(data1 == data2);
            Console.WriteLine(data1.Equals(data2));
            Console.WriteLine(data1.SequenceEqual(data2));
        }
    }
}
