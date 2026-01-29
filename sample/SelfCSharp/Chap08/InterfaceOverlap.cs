namespace SelfCSharp.Chap08.Implement
{
    interface IHoge
    {
        void Foo(string str);
    }

    interface IHoge2
    {
        void Foo(string str2);
    }

    internal class MyClass : IHoge, IHoge2
    {
        public void Foo(string str)
        {
            Console.WriteLine($"暗黙的＝{str}");
        }

        void IHoge.Foo(string str)
        {
            Console.WriteLine($"IHoge.Foo＝{str}");
        }

        void IHoge2.Foo(string str)
        {
            Console.WriteLine($"IHoge2.Foo＝{str}");
        }
    }

    internal class InterfaceOverlap
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            mc.Foo("い");

            var ih = (IHoge)mc;
            ih.Foo("ろ");

            var ih2 = (IHoge2)mc;
            ih2.Foo("は");
        }
    }
}
