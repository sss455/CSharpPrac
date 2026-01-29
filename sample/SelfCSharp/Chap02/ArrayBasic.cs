namespace SelfCSharp.Chap02
{
    internal class ArrayBasic
    {
        static void Main(string[] args)
        {
            //int[] data = new int[5];

            //int[] data = { 1, 2, 3, 4, 5 };

            //string[] data = {
            //    "すずめの子 そこのけそこのけ お馬が通る",
            //    "目には青葉 山ほととぎす 初がつお",
            //    "朝顔に つるべとられて もらい水",
            //};

            //int[] data;
            //data = new[] { 1, 2, 3, 4, 5 };

            var data = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(data[0]);

            Console.WriteLine(data.Length);
        }
    }
}
