using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeParse
    {
        static void Main(string[] args)
        {
            var dt1 = "2022/02/15 13:17:23";
            Console.WriteLine(DateTime.Parse(dt1));

            var dt2 = "令和4年2月15日 13時17分23秒";
            Console.WriteLine(DateTime.Parse(dt2));

            var dt3 = "Dienstag, 15. Februar 2022 13:17:23";
            Console.WriteLine(DateTime.Parse(dt3, new CultureInfo("de-DE")));
        }
    }
}
