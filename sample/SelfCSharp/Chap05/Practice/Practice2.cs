using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05.Practice
{
    internal class Practice2
    {
        static void Main(string[] args)
        {
            var rgx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[a-z_0-9-./?%&=]*)?",
                RegexOptions.IgnoreCase);

            using (var reader = new StreamReader(@"C:\data\SelfCSharp\Chap05\sample.dat"))
            {
                while (!reader.EndOfStream)
                {
                    var result = rgx.Matches(reader.ReadLine());
                    foreach (Match m in result)
                    {
                        Console.WriteLine(m.Value);
                    }
                }
            }

        }
    }
}
