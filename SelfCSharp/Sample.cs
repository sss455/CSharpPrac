using System;
using System.Text;

namespace SelfCSharp
{
    internal class Sample
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------
            // Equalsメソッドの 同一性／同値性 確認
            //----------------------------------------------------------
            var builder1 = new StringBuilder();
            builder1.Append( "あい" );
            builder1.Append("うえお");
            var builder2 = new StringBuilder();
            builder2.Append( "あいう" );
            builder2.Append("えお");

            Console.WriteLine(builder1.Equals(builder2));           // 結果：true
            Console.WriteLine(Object.Equals(builder1, builder2));   // 結果：false
            Console.WriteLine();

            String str1 = "あいう";
            String str2 = "あいう";

            Console.WriteLine(str1 == str2);                        // 結果：true
            Console.WriteLine(str1.Equals(str2));                   // 結果：true
            Console.WriteLine(Object.Equals(str1, str2));           // 結果：true

            Console.WriteLine(Object.Equals(null, null));           // 結果：true



            //----------------------------------------------------------
            // メモ
            //----------------------------------------------------------

        }
    }
}
