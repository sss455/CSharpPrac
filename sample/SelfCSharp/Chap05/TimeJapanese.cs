using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class TimeJapanese
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23);
            var cal = new CultureInfo("ja-JP");
            cal.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine(dt.ToString("ggyy年MM月dd日（ddd）tt hh:mm:ss", cal));
        }
    }
}
