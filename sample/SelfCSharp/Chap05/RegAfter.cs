using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegAfter
    {
        static void Main(string[] args)
        {
            var str = "<p>サポートサイト<a href='https://www.wings.msn.to/'>https://www.wings.msn.to/</a></p>";
            var rgx = new Regex(@"<a href='(.+?)'>\1</a>");
            //var rgx = new Regex(@"<a href='(?<link>.+?)'>\k<link></a>");
            var match = rgx.Match(str);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
