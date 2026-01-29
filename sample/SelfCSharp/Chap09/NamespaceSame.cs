using System.Globalization;
using SelfCSharp.Chap09.Other;

namespace SelfCSharp.Chap09.Ns
{
    internal class NamespaceSame
    {
        static void Main(string[] args)
        {
            //var ci = new CultureInfo("ja-JP");
            var ci = new System.Globalization.CultureInfo("ja-JP");
        }
    }
}
