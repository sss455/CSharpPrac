namespace SelfCSharp.Chap05
{
    internal class StrSplit
    {
        static void Main(string[] args)
        {
            var str1 = "うめ,もも,さくら";
            var result1 = str1.Split(',');
            Console.WriteLine(string.Join("＆", result1));

            var str2 = "うめ,もも,さくら|あんず";
            var result2 = str2.Split(',', '|');
            Console.WriteLine(string.Join("＆", result2));

            var str3 = "うめ  もも\tさくら\nあんず";
            var result3 = str3.Split();
            Console.WriteLine(string.Join("＆", result3));

            var str4 = "うめ,もも,さくら,あんず";
            var result4 = str4.Split(',' , 2);
            Console.WriteLine(string.Join("＆", result4));

            var str5 = "うめ\t\tもも\tすもも\tあんず";
            var result5 = str5.Split('\t',
                StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join("＆", result5));

            var result6 = str5.Split('\t');
            Console.WriteLine(string.Join("＆", result6));
        }
    }
}
