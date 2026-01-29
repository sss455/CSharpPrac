namespace SelfCSharp.Chap11
{
    internal class ReflectBasic
    {
        static void Main(string[] args)
        {
            var tp = typeof(Person);
            var op = Activator.CreateInstance(tp);
            Console.WriteLine(op);

            var tf = typeof(FileInfo);
            var cf = tf.GetConstructor(new[] { typeof(string) });
            var of = cf?.Invoke(new[] { @"c:\data\result.txt" });
            Console.WriteLine(of);
        }
    }
}
