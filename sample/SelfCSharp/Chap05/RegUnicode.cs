using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegUnicode
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
            var msg = "ただいま、WINGSプロジェクトメンバー募集中です！";
            ShowMatch(msg, new Regex(@"\p{IsHiragana}+"));
            ShowMatch(msg, new Regex(@"\p{IsKatakana}+"));
            ShowMatch(msg, new Regex(@"\p{IsCJKUnifiedIdeographs}+"));
        }
    }
}
