namespace SelfCSharp.Chap05.Practice
{
    internal class Practice1
    {
        static void Main(string[] args)
        {
            var str = "となりのきゃくはよくきゃくくうきゃくだ";
            Console.WriteLine(str.LastIndexOf("きゃく"));

            var loc = "弘前";
            var temp = 15.156;
            Console.WriteLine(String.Format("{0}の気温は{1:F1}℃です。", loc, temp));

            var str2 = "ボクの名前は太郎です。";
            Console.WriteLine(str2.Replace("ボク", "私"));

            var dt = DateTime.Now;
            Console.WriteLine(dt.Add(new TimeSpan(5, 4, 0, 0)));

            var dt1 = new DateTime(2020, 2, 13);
            var dt2 = new DateTime(2022, 8, 4);
            Console.WriteLine(dt2.Subtract(dt1));

        }
    }
}
