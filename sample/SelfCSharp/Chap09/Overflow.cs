namespace SelfCSharp.Chap09
{
    internal class Overflow
    {
        static void Main(string[] args)
        {
            var i = int.MaxValue;
            Console.WriteLine(++i);

            //checkedブロックで書き換え
            //try
            //{
            //    checked
            //    {
            //        var i = int.MaxValue;
            //        Console.WriteLine(++i);
            //        //Console.WriteLine(unchecked(++i));
            //    }
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("オーバーフロー発生！");
            //}

            //checked演算子で書き換え
            //var i = int.MaxValue;
            ////var i = 1;
            //Console.WriteLine(checked(++i));

        }
    }
}
