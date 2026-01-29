using System;

using SelfCSharp.Chap09.Priority1;
using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{
    internal class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority1名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority2
{
    internal class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority2名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority3
{
    internal class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority3名前空間");
        }
    }
}

//internal class MyUtil
//{
//    public static void Run() {
//        Console.WriteLine("グローバル名前空間");
//    }
//}


namespace SelfCSharp.Chap09.Priority
{
    using SelfCSharp.Chap09.Priority3;

    internal class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("現在の名前空間");
        }
    }

    internal class NamespacePriority
    {
        static void Main(string[] args)
        {
            MyUtil.Run();
        }
    }
}