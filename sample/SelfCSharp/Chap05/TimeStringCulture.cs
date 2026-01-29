using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeStringCulture
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23);
            var culture = new CultureInfo("ja-JP");
            //var culture = new CultureInfo("en-US");

            Console.WriteLine(dt.ToString("f", culture));
            Console.WriteLine(dt.ToString("yy/MM/dd ddd曜日 tt hh:mm:ss", culture));
        }
    }
}
