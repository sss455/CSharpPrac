namespace SelfCSharp.Chap02
{
    internal class NullForgive
    {
        static void Main(string[] args)
        {
            //string?[] format = { "2022-12-25 10:16:23" };
            //var dt = DateTime.Parse(format[0]);
            //Console.WriteLine(dt);

            //nullチェックする場合
            //string?[] format = { "2022-12-25 10:16:23" };
            //if (format[0] is { } item)
            //{
            //    var dt = DateTime.Parse(item);
            //    Console.WriteLine(dt);
            //}

            //null免除演算子を使う場合
            string?[] format = { "2022-12-25 10:16:23" };
            var dt = DateTime.Parse(format[0]!);
            Console.WriteLine(dt);

        }
    }
}
