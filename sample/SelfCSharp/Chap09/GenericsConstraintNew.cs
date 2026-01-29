namespace SelfCSharp.Chap09.GenericsConst
{
    internal class MyGenerics<T> where T : new()
    {
        public void Hoge()
        {
            var value = new T();
        }
    }

    internal class GenericsConstraintNew
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<int>();
        }
    }
}
