//using static SelfCSharp.Chap09.Nested.MyClass;

namespace SelfCSharp.Chap09.Nested
{
    internal class MyClass
    {
        class MyHelper
        //public class MyHelper
        {
            public void Show()
            {
                Console.WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }

    internal class NestedBasic
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.Run();

            //var h = new MyClass.MyHelper();

            //var h = new MyHelper();
        }
    }
}
