namespace SelfCSharp.Chap09
{
    internal class TryWhen
    {
        static void Main(string[] args)
        {
            try
            {
                var f = new StreamReader(@"C:\nothing.dat");
            }
            catch (FileNotFoundException ex) when (ex.Message.Contains(".dat"))
            {
                Console.WriteLine("存在しない.datファイルが指定されました。");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("存在しないファイルが指定されました。");
            }
        }
    }
}
