using System;

namespace SelfCSharp.Chap05
{
    internal class StreamRead
    {
        static void Main(string[] args)
        {
            // ReadToEndメソッド（テキストの内容を一気に読み込む）
            using(var reader = new StreamReader(@"c:\data\read.txt"))
            {
                Console.WriteLine( reader.ReadToEnd() );
            }
            Console.WriteLine("--------------------------------------------------------------------------");

            // ReadLineメソッド（テキストを行単位に読み込む）
            using (var reader = new StreamReader(@"c:\data\read.txt"))
            {
                while ( !reader.EndOfStream )
                {
                    Console.WriteLine( reader.ReadLine() );
                }
            }
        }
    }
}
