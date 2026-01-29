namespace SelfCSharp.Chap07
{
    internal class ScopeBlock
    {
        static void Main(string[] args)
        {
            var data = "ローカルスコープ";
            {
                //var data = "ブロックスコープ";
                Console.WriteLine(data);
            }
            Console.WriteLine(data);
        }
    }
}
