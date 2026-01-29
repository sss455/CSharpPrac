using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegReplace
    {
        static void Main(string[] args)
        {
            var str = "サポートサイトはhttps://wings.msn.to/です。";
            var rgx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[a-z_0-9-./?%&=]*)?",
                RegexOptions.IgnoreCase);
            Console.WriteLine(rgx.Replace(str, "<a href='$0'>$0</a>"));
        }
    }
}
