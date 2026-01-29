namespace SelfCSharp.Chap07.MethodArgs
{
    internal class ArgsNamed
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                lastName = "山田",
                firstName = "太郎"
            };
            p.Show(title: "氏");
            p.Show(title: "氏", greeting: "おはよう");
            //p.Show("おはよう", title: "氏");
            //p.Show(greeting: "おはよう", "氏");
            //p.Show("氏", greeting: "こんばんは");
        }
    }
}
