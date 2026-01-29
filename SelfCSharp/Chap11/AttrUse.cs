using System;

namespace SelfCSharp.Chap11
{
    [Version("1.0.0", Beta = true)]
    internal class AttrUse
    {
        static void Main(string[] args)
        {
            var t = typeof(AttrUse);
            //var attr = Attribute.GetCustomAttribute(t, typeof(VersionAttribute)) as VersionAttribute;
            var attr = (VersionAttribute?) Attribute.GetCustomAttribute(t, typeof(VersionAttribute));

            if (attr is not null)
            {
                //Console.WriteLine(t);
                Console.WriteLine(attr.Number);
                Console.WriteLine("β版で" + (attr.Beta ? "す" : "ではありません。"));
            }
        }
    }
}
