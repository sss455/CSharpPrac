using System;
using System.Text;

namespace SelfCSharp.Chap05
{
    internal class StreamWrite
    {
        static void Main(string[] args)
        {
            // 上書き（既定）
            using (var writer = new StreamWriter(@"c:\data\data.log"))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }

            // 追記、UTF-8（既定）
            using (var writer = new StreamWriter( @"c:\data\data.log", append: true ))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }

            // 追記、Shift-JIS
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance );
            using (var writer = new StreamWriter(@"c:\data\data.log", append: true, Encoding.GetEncoding("Shift-JIS")))
            {
                // WriteLineメソッド
                writer.WriteLine(DateTime.Now.ToString());
                // Writeメソッド
                writer.Write(DateTime.Now.ToString() + "\r\n");
                writer.WriteLine("--------------------------");
            }

            // File.WriteAllLinesメソッド
            var lines = new[] { "2021/12/31 23:59:59", "2022/01/01 06:15:30" };
            File.WriteAllLines(@"c:\data\data2.log", lines);
        }
    }
}
