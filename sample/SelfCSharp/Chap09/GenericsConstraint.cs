namespace SelfCSharp.Chap09
{
    internal class MyGenerics<T> where T : IComparable<T>
    {
        public int Hoge(T x, T y)
        {
            return x.CompareTo(y);
        }
    }

    internal class GenericsConstraint
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<string>();
            Console.WriteLine(m.Hoge("あいう", "あいう"));
        }
    }
}
