using System;
using System.Reflection;

namespace SelfCSharp.Chap11
{
    internal class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }


    internal class ReflectBasic
    {
        static void Main(string[] args)
        {
            // 引数なしのコンストラクタ―を利用してPersonオブジェクトを生成
            var tp = typeof(Person);
            var op1 = Activator.CreateInstance(tp);
            Console.WriteLine(op1);

            // string型を受け取るコンストラクターでFileInfoオブジェクトを生成
            var tf = typeof(FileInfo);
            //var cf = tf.GetConstructor( new[] { typeof(string) } );
            //var op2 = cf?.Invoke( new[] { @"c:\data\result.txt" } );
            ConstructorInfo? cf = tf.GetConstructor( new[] { typeof(string) } );
            var op2 = (FileInfo?) cf?.Invoke( new[] { @"c:\data\result.txt" } );
            Console.WriteLine(op2);
        }
    }
}
