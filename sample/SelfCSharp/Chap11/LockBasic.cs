namespace SelfCSharp.Chap11
{
    internal class LockBasic
    {
        object lockobj = new object();
        public int Count { get; private set; } = 0;
        //public volatile int Count = 0;

        static void Main(string[] args)
        {
            const int TaskNum = 500000;
            var ts = new Task[TaskNum];
            var tb = new LockBasic();

            for (var i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            for (var i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            Console.WriteLine(tb.Count);
        }

        void Increment()
        {
            lock (lockobj)
            {
                this.Count++;
            }
        }
    }
}
