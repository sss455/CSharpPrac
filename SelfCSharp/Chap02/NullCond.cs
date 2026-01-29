using System;

namespace SelfCSharp.Chap02
{
    internal class NullCond
    {
        static void Main(string[] args)
        {
            string str = null;
            string unspace = null;

            // C# 5以前
            //string unspace1 = str.Trim();    // ←NullREferenceExceptionエラー

            // Nullチェック
            if (str != null)
            {
                unspace = str.Trim();
            }

            // C# 5以降
            unspace = str?.Trim();     // ★null条件演算子「?.」→ strがnullでもエラーにならない

            Console.WriteLine(unspace);
        }
    }
}
