namespace SelfCSharp.Chap04.Practice
{
    internal class PIf
    {
        static void Main(string[] args)
        {
            var point = 75;
            if (point >= 90)
            {
                Console.WriteLine("優");
            }
            else if (point >= 70)
            {
                Console.WriteLine("良");
            }
            else if (point >= 50)
            {
                Console.WriteLine("可");
            }
            else
            {
                Console.WriteLine("不可");
            }
        }
    }
}
