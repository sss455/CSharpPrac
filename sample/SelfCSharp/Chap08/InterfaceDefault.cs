namespace SelfCSharp.Chap08
{
    public interface IHoge
    {
        void Log(string msg)
        {
            Console.WriteLine($"Log: {msg}");
        }
    }

    public class Hoge : IHoge { }
    //public class Hoge : IHoge
    //{
    //    public void Log(string msg)
    //    {
    //        Console.WriteLine($"Hoge: {msg}");
    //    }
    //}

    internal class InterfaceDefault
    {
        static void Main(string[] args)
        {
            var h = new Hoge();
            ((IHoge)h).Log("任意のメッセージ");
        }
    }
}
