using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegIsMatch
    {
        static void Main(string[] args)
        {
            var tel = new[] { "080-0000-0000", "084-000-0000", "184-0000" };
            var rgx = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");
            foreach (var t in tel)
            {
                Console.WriteLine(rgx.IsMatch(t) ? t : "アンマッチ");
            }
        }
    }
}
