using System.Text;

namespace SelfCSharp.Chap05.Practice
{
    internal class Practice3
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var writer = new StreamWriter(@"c:\data\data.dat", true,
                Encoding.GetEncoding("Shift-JIS")))
            {
                writer.WriteLine(string.Join(",", args));
            }
        }
    }
}
