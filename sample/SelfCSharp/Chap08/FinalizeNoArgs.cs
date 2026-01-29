namespace SelfCSharp.Chap08.Finalize
{
    internal class MyParent
    {
        ~MyParent()
        {
            Console.WriteLine("親です。");
        }
    }

    internal class MyChild : MyParent
    {
        ~MyChild()
        {
            Console.WriteLine("子です。");
        }
    }

    internal class FinalizeNoArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}
