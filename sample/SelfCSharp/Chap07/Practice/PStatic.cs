namespace SelfCSharp.Chap07.Practice
{
    internal static class MyClass
    {
        public static double GetBmi(double weight, double height)
        {
            return weight / (height * height);
        }
    }

    internal class PStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.GetBmi(55, 1.7));
        }
    }
}
