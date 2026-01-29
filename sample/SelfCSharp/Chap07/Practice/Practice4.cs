namespace SelfCSharp.Chap07.Practice
{
    internal class Practice4
    {
        static int Increment(ref int value)
        {
            value += 5;
            return value;
        }

        static void Main(string[] args)
        {
            int value = 10;
            Console.WriteLine(Increment(ref value));
            Console.WriteLine(value);
        }
    }
}
