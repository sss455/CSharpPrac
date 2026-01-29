namespace SelfCSharp.Chap08.Construct
{
    internal class MyParent
    {
        public MyParent(string childName)
        {
            Console.WriteLine($"{childName}の親です。");
        }
    }

    internal class MyChild : MyParent
    {
        //public MyChild(string childName)
        public MyChild(string childName) : base(childName)
        {
            Console.WriteLine($"子の{childName}です。");
        }
    }

    internal class ConstArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild("花子");
        }
    }
}
