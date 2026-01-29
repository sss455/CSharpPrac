namespace SelfCSharp.Chap09.NestIncluded
{
    internal class MyClass
    {
        string str1 = "包含・インスタンス";
        static string str2 = "包含・静的";

        public void Show()
        {
            var h = new MyHelper();
            h.Show();
            //Console.WriteLine(h.str1);
            //Console.WriteLine(MyHelper.str2);
        }

        class MyHelper
        {
            string str1 = "入れ子・インスタンス";
            static string str2 = "入れ子・静的";

            public void Show()
            {
                var c = new MyClass();
                Console.WriteLine(c.str1);
                Console.WriteLine(MyClass.str2);
            }
        }
    }

    internal class NestedAccess
    {
        static void Main(string[] args)
        {
            var mc = new MyClass();
            mc.Show();
        }
    }
}
