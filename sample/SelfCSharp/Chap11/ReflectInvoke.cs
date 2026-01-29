namespace SelfCSharp.Chap11
{
    internal class ReflectInvoke
    {
        static void Main(string[] args)
        {
            var fi = typeof(FileInfo);
            var cf = fi.GetConstructor(new Type[] { typeof(string) });
            var obj = cf?.Invoke(new[] { @"c:\data\result.txt" });

            var m = fi.GetMethod("CopyTo", new Type[] { typeof(String) });
            m?.Invoke(obj, new object[] { @"c:\data\copy.txt" });
        }
    }
}
