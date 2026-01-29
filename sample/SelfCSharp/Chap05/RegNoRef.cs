using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegNoRef
    {
        static void Main(string[] args)
        {
            var msg = "仕事用はwings@example.comです。プライベート用はYAMA@example.comです。";
            //var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(\.[a-z0-9-]+)*)",
            //    RegexOptions.IgnoreCase);

            var rgx = new Regex(@"([a-z0-9.!#$%&'*+/=?^_{|}~-]+)@([a-z0-9-]+(?:\.[a-z0-9-]+)*)",
                RegexOptions.IgnoreCase);
            var result = rgx.Matches(msg);
            foreach (Match m in result)
            {
                foreach (Group sub in m.Groups)
                {
                    Console.WriteLine(sub.Value);
                }
            }
        }
    }
}
