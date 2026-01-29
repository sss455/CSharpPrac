namespace SelfCSharp.Chap07
{
    internal class ScopeBasic
    {
        public string data = "フィールド";

        public string Show()
        {
            string data = "ローカル";
            return data;

            //隠ぺいされたフィールドにアクセス
            //return this.data;
        }

        static void Main(string[] args)
        {
            var s = new ScopeBasic();
            Console.WriteLine(s.Show());
            Console.WriteLine(s.data);
        }
    }
}
