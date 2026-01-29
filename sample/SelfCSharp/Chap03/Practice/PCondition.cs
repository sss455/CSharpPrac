namespace SelfCSharp.Chap03.Practice
{
    internal class PCondition
    {
        static void Main(string[] args)
        {
            string value = "こんにちは";
            Console.WriteLine(value != null ? value : "既定値");
            Console.WriteLine(value ?? "既定値");
        }
    }
}
