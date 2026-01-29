using System.Dynamic;

namespace SelfCSharp.Chap11
{
    internal class ExpandoBasic
    {
        static void Main(string[] args)
        {
            dynamic e = new ExpandoObject();
            e.Count = 1;
            e.Name = "山田";
            Console.WriteLine(e.Count);
            Console.WriteLine(e.Name);

            dynamic d = new ExpandoObject();
            d.Add = (Func<double, double, double>)((x, y) => x + y);
            Console.WriteLine(d.Add(10, 5));

            //Console.WriteLine(((IDictionary<string, object>)d).ContainsKey("Hoge"));

        }
    }
}
