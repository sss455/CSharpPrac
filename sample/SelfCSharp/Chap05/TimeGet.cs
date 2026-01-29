namespace SelfCSharp.Chap05
{
    internal class TimeGet
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2022, 02, 15, 13, 17, 23, 123);
            Console.WriteLine($"{dt.Year}年{dt.Month}月{dt.Day}日 {dt.DayOfWeek} {dt.Hour}時{dt.Minute}分{dt.Second}秒{dt.Millisecond}ミリ秒");
            Console.WriteLine($"経過時間:{dt.Ticks} 年初から{dt.DayOfYear}日目");
        }
    }
}
