using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegIgnore
    {
        static void Main(string[] args)
        {
            var str = "仕事用はwings@example.comです。プライベート用はYAMA@example.comです。";
            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)", RegexOptions.IgnoreCase);

            //オプション不使用
            //var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)");

            //オプションを使用しない場合（別解）
            //var rgx = new Regex(@"([A-Za-z0-9.!#$%&'*+/=?^_{|}~-]+)@([A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*)");

            var result = rgx.Matches(str);

            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
