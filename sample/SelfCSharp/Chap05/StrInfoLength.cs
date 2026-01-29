using System.Globalization;

namespace SelfCSharp.Chap05
{
    internal class StrInfoLength
    {
        static void Main(string[] args)
        {
            var str = "𠮟る";
            var strInfo = new StringInfo(str);
            Console.WriteLine(strInfo.LengthInTextElements);
        }
    }
}
