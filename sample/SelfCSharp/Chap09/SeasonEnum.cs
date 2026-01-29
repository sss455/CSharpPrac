namespace SelfCSharp.Chap09
{
    enum Season
    {
        //enum Season : long {

        Spring,
        //Spring = 1,
        Summer,
        Autumn,
        Winter,
        //All = Spring + Summer + Autumn + Winter,
    }

    internal class SeasonEnum
    {
        public void ProcessSeason(Season season)
        {
            Console.WriteLine(season);
        }
    }

    internal class SeasonEnumClient
    {
        static void Main(string[] args)
        {
            var se = new SeasonEnum();
            se.ProcessSeason(Season.Spring);
            //se.ProcessSeason(4);
            //se.ProcessSeason(Season.All);          
        }
    }
}
