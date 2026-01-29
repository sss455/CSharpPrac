namespace SelfCSharp.Chap04
{
    internal class SwitchType
    {
        static void Main(string[] args)
        {
            object obj = -123;
            //object obj = "wings";
            switch (obj)
            {
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;
                case string str:
                    Console.WriteLine(str[0]);
                    break;
                default:
                    Console.WriteLine("意図しない型です。");
                    break;
            }
        }
    }
}
