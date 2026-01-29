namespace SelfCSharp.Chap11
{
    internal class DynamicBasic
    {
        static void Main(string[] args)
        {
            dynamic d = 10;
            d = "ほげ";
            d.Hoge();
        }
    }
}
