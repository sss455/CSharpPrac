using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegSplit
    {
        static void Main(string[] args)
        {
            var str = "にわに3わうらにわに51わにわとりがいる";
            var rgx = new Regex(@"\d{1,}わ");
            var result = rgx.Split(str);
            Console.WriteLine(string.Join("、", result));
        }
    }
}
