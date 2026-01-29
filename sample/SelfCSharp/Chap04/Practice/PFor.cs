namespace SelfCSharp.Chap04.Practice
{
    internal class PFor
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < 10; j++)
                {
                    Console.Write($"{i * j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
