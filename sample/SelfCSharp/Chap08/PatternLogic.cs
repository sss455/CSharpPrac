namespace SelfCSharp.Chap08
{
    internal class PatternLogic
    {
        static void Main(string[] args)
        {
            var point = 45;
            Console.WriteLine(point switch
            {
                < 0 or > 100 => "異常値",
                >= 0 and <= 100 => "正常値",
            });
        }
    }
}
