using System;

namespace SelfCSharp.Chap10
{
    internal class LambdaCapture
    {
        static Action CreateAction(int init)
        {
            int value = init;
            return () =>
            {
                value++;
                Console.WriteLine(value);
            };
        }

        static void Main(string[] args)
        {
            var lc = new LambdaCapture();
            var show = CreateAction(10);
            show();
            show();
        }
    }
}
