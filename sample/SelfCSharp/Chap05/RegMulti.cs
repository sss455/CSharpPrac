using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegMulti
    {
        static void Main(string[] args)
        {
            var str = "10人のインディアン。\n1年生になったら";
            //var rgx = new Regex(@"^\d+");
            var rgx = new Regex(@"^\d+", RegexOptions.Multiline);
            var result = rgx.Matches(str);

            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
