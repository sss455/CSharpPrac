using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegGroupNamed
    {
        static void Main(string[] args)
        {
            var str = "電話番号は、084-000-0000です。";
            var rgx = new Regex(@"(?<area>\d{2,4})-(?<city>\d{2,4})-(?<local>\d{4})");
            var match = rgx.Match(str);
            if (match.Success)
            {
                var gp = match.Groups;
                Console.WriteLine($"市外局番：{gp["area"]}");
                Console.WriteLine($"市内局番：{gp["city"]}");
                Console.WriteLine($"加入者番号：{gp["local"]}");
            }
        }
    }
}
