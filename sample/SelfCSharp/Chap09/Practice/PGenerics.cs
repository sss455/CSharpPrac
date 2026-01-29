namespace SelfCSharp.Chap09.Practice
{
    internal class MyGenerics<T> where T : new()
    {
        T obj = new T();
    }

    internal class PGenerics
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<int>();
        }
    }
}
