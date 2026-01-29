using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegGroup
    {
        static void Main(string[] args)
        {
            var str = "電話番号は、084-000-0000です。";
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            //var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})",
            //    RegexOptions.ExplicitCapture);
            var match = rgx.Match(str);
            if (match.Success)
            {
                var gp = match.Groups;
                Console.WriteLine($"市外局番：{gp[1]}");
                Console.WriteLine($"市内局番：{gp[2]}");
                Console.WriteLine($"加入者番号：{gp[3]}");
            }
        }
    }
}
