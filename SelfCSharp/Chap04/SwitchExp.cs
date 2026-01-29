using System;

namespace SelfCSharp.Chap04
{
    internal class SwitchExp
    {
        static void Main(string[] args)
        {
            var rank = "甲";

            Console.WriteLine(
                // [8.0] switch式
                rank switch
                {
                    "甲" => "大変良いです。",
                    "乙" => "良いです。",
                    "丙" => "がんばりましょう。",
                    _ => "???",
                }
            );

            var result = rank switch
            {
                "甲" => "大変良いです。",
                "乙" => "良いです。",
                "丙" => "がんばりましょう。",
                _ => "???",
            };
            Console.WriteLine(result);
        }
    }
}
