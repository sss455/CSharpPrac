using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10
{

    internal class DelegateAnonymous
    {
        // 
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (string value in data)
            {
                Console.WriteLine(output(value));
            }
        }


        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };

            var dm = new DelegateAnonymous();
            
            dm.ArrayWalk(
                data,
                // デリゲート型の引数に匿名メソッドを渡す
                delegate (string str)
                {
                    return $"[{str}]";
                }
            );
        }
    }
}
