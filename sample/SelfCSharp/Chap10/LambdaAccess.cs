namespace SelfCSharp.Chap10
{
    internal class LambdaAccess
    {
        static void Main(string[] args)
        {
            var msg = "鈴木次郎";
            var show = () => { Console.WriteLine(msg); };
            show();
        }
    }
}
