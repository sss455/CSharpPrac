namespace SelfCSharp.Chap09
{
    internal partial class MyNewPartial
    {
        public partial string LongText()
        {
            return "特定のルールで自動生成された、冗長な文字列の例";
        }
    }
    internal partial class MyNewPartial
    {
        public partial string LongText();

        static void Main(string[] args)
        {
            var np = new MyNewPartial();
            Console.WriteLine(np.LongText());
        }
    }
}
