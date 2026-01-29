namespace SelfCSharp.Chap07.ClassField
{
    internal class MyApp
    {
        public static readonly string Title = "独習C#";
        //public const string Title = "独習C#";
    }

    internal class FieldStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyApp.Title);
            //MyApp.Title = "本気でおぼえるC#";
        }
    }
}
