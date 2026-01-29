using System;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Chap07
{
    //internal class myInitializer
    //{
    //    /// <summary>
    //    ///  モジュール識別子
    //    /// </summary>
    //    [ModuleInitializer]
    //    public static void init1()
    //    {
    //        Console.WriteLine("init1 is cAlled!!");
    //    }

    //    /// <summary>
    //    ///  モジュール識別子
    //    /// </summary>
    //    [ModuleInitializer]
    //    public static void init2()
    //    {
    //        Console.WriteLine("init2 is called!!");
    //    }
    //}


    internal class ModuleInit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main is called!!");
        }
    }
}
