namespace SelfCSharp.Chap07.Finalize
{
    internal class MyProcess
    {
        public MyProcess()
        {
            Console.WriteLine("constructor");
        }

        ~MyProcess()
        {
            Console.WriteLine("finalizer");
        }
    }

    internal class FinalizeBasic
    {
        static void Main(string[] args)
        {
            var mp = new MyProcess();
        }
    }
}
