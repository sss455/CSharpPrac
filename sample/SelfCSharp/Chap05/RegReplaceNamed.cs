using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegReplaceNamed
    {
        static void Main(string[] args)
        {
            var str = "仕事用はwings@example.comです。";
            var rgx = new Regex(@"(?<localName>[a-z0-9.!#$%&'*+/=?^_{|}~-]+)@(?<domain>[a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);
            Console.WriteLine(rgx.Replace(str, "${domain}の${localName}"));
        }
    }
}
