using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegEvaluate
    {
        static void Main(string[] args)
        {
            var str = "メールアドレスはwings@example.comです。";
            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)");
            Console.WriteLine(rgx.Replace(str, m => m.Value.ToUpper()));
        }
    }
}
