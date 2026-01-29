namespace SelfCSharp.Chap07
{
    internal class MethodLocalShadow
    {
        static void Main(string[] args)
        {
            var msg = "Local Variable";

            void MyLocal()
            {
                var msg = "Inner Variable";
                Console.WriteLine(msg);
            }
            MyLocal();
            Console.WriteLine(msg);
        }
    }
}
