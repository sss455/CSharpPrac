using System.Globalization;
using MyCulture = SelfCSharp.Chap09.Other.CultureInfo;

namespace SelfCSharp.Chap09.Ns
{
    internal class NamespaceAlias2
    {
        static void Main(string[] args)
        {
            var ci = new MyCulture("ja-JP");
        }
    }
}
