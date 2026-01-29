using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08.Implement
{
    interface IHoge1
    {
        void Foo(string str);
    }

    interface IHoge2
    {
        void Foo(string str);
    }

    internal class MyClass : IHoge1, IHoge2
    {
        // 暗黙的な実装
        public void Foo(string str)
        {
            Console.WriteLine($"暗黙的＝{str}");
        }

        // 明示的な実装（Hoge1）
        void IHoge1.Foo(string str)
        {
            Console.WriteLine($"IHoge1.Foo＝{str}");
        }

        // 明示的な実装（Hoge2）
        void IHoge2.Foo(string str)
        {
            Console.WriteLine($"IHoge2.Foo＝{str}");
        }
    }

    internal class InterfaceOverlap
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Foo("い");

            var iHoge1 = (IHoge1)myClass;
            iHoge1.Foo("ろ");

            var iHoge2 = (IHoge2)myClass;
            iHoge2.Foo("は");
        }
    }
}
