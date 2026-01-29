using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegRead
    {
        static void ShowMatch(string msg, Regex reg)
        {
            foreach (Match result in reg.Matches(msg))
            {
                Console.WriteLine(result.Value);
            }
            Console.WriteLine("------------------------------");
        }
        static void Main(string[] args)
        {
            var reg1 = new Regex("いろ(?=はに)");
            var reg2 = new Regex("いろ(?!はに)");
            var reg3 = new Regex("(?<=。)いろ");
            var reg4 = new Regex("(?<!。)いろ");
            var msg1 = "いろはにほへと";
            var msg2 = "いろものですね。いろいろと";

            ShowMatch(msg1, reg1);
            ShowMatch(msg2, reg1);
            ShowMatch(msg1, reg2);
            ShowMatch(msg2, reg2);
            ShowMatch(msg1, reg3);
            ShowMatch(msg2, reg3);
            ShowMatch(msg1, reg4);
            ShowMatch(msg2, reg4);
        }
    }
}
