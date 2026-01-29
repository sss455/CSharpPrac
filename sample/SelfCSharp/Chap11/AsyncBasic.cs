namespace SelfCSharp.Chap11
{
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            Task t = RunAsync();
            Console.WriteLine("...他の処理...");
            t.Wait();
        }

        static async Task RunAsync()
        {
            await Task.Run(() => Count(1));
            Console.WriteLine("処理が終了しました。");
        }

        static void Count(int n)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Task{n}: {i}");
            }
        }
    }
}
