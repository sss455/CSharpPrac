namespace SelfCSharp.Chap11
{
    internal class LockBasicBad
    {
        public int Count { get; private set; } = 0;

        static void Main(string[] args)
        {
            const int TaskNum = 500000;
            var ts = new Task[TaskNum];
            var tb = new LockBasicBad();

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
            this.Count++;
        }
    }
}
