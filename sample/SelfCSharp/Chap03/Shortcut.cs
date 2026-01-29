namespace SelfCSharp.Chap03
{
    internal class Shortcut
    {
        static void Main(string[] args)
        {
            //string? str = null;
            string str = "https://wings.msn.to/";
            if (str != null && str.StartsWith("https://"))
            {
                Console.WriteLine("「https://～」で始まります。");
            }

        }
    }
}
