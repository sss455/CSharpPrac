namespace SelfCSharp.Chap07.ClassMethod
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";

        public string Show()
        {
            return $"名前は{this.lastName}{this.firstName}です。";

        }

        //戻り値がない場合
        //public void Show()
        //{
        //    Console.WriteLine($"名前は{this.lastName}{this.firstName}です。");
        //}

        //何もしない
        //public void Show()
        //{
        //    Console.WriteLine($"名前は{this.lastName}{this.firstName}です。");
        //    return;
        //}
    }

    internal class MethodBasic
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.firstName = "太郎";
            p.lastName = "山田";
            Console.WriteLine(p.Show());
            //p.Show();
        }
    }
}
