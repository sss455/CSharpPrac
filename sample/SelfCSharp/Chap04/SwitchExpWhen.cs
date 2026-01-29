namespace SelfCSharp.Chap04
{
    internal class SwitchExpWhen
    {
        static void Main(string[] args)
        {
            object obj = 123;
            Console.WriteLine(obj switch
            {
                int i when i >= 15 => "15以上の数値です。",
                int i => "数値です。",
                string str when str.Length < 10 => "10文字未満の文字列です",
                _ => "意図しない値です。"
            });
        }
    }
}
