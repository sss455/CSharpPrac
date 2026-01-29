using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    internal class RegLongest
    {
        static void Main(string[] args)
        {
            var tags = "<p><strong>WINGS</strong>サイト<a href='index.html'><img src='wings.jpg'></img></a></p>";
            var rgx = new Regex(@"<.+>");
            //var rgx = new Regex(@"<.+?>");

            var result = rgx.Matches(tags);

            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
