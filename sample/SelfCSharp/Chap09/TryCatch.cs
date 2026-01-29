namespace SelfCSharp.Chap09
{
    internal class TryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader(@"C:\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ファイルが見つかりませんでした。");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
