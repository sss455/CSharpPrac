namespace SelfCSharp.Chap07
{
    internal class ScopeBlock2
    {
        static void Main(string[] args)
        {
            {
                //var data = "ブロックスコープ";
                //Console.WriteLine(data);
            }
            var data = "ローカルスコープ";
            Console.WriteLine(data);
        }
    }
}
