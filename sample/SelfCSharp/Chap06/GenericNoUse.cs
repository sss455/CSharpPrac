using System.Collections;

namespace SelfCSharp.Chap06
{
    internal class GenericNoUse
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add("あいうえお");
            //list.Add("かきくけこ");

            list.Add(12345);
            string str = (string)list[0];

            Console.WriteLine(str);
        }
    }
}
