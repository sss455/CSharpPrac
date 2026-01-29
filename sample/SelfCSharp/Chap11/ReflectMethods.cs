namespace SelfCSharp.Chap11
{
    internal class ReflectMethods
    {
        static void Main(string[] args)
        {
            var t = typeof(string);
            foreach (var m in t.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
