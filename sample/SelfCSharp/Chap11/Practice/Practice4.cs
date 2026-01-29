namespace SelfCSharp.Chap11.Practice
{
    delegate void MyEventHandler(int v);

    internal class MyEvent
    {
        public event MyEventHandler OddEvent = v => { };
        public event MyEventHandler EvenEvent = v => { };

        public void Run(int n)
        {
            for (var i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    EvenEvent(i);
                }
                else
                {
                    OddEvent(i);
                }
            }
        }
    }

    internal class Practice4
    {
        static void Main(string[] args)
        {
            var e = new MyEvent();
            e.EvenEvent += v => { Console.WriteLine(v); };
            e.OddEvent += v => { Console.WriteLine("Hoge"); };
            e.Run(20);
        }
    }
}
