namespace SelfCSharp.Chap05
{
    internal class ArrayExample
    {
        static void Main(string[] args)
        {
            var array1 = new[] { "dog", "cat", "mouse", "fox", "lion" };
            Array.Sort(array1);
            Console.WriteLine(string.Join("＆ ", array1));
            Console.WriteLine(Array.BinarySearch(array1, "mouse"));

            var array2 = new[] { "あ", "い", "う", "え", "お" };
            var array3 = new string[5];
            Array.Copy(array2, 1, array3, 1, 3);
            Console.WriteLine(string.Join("＆ ", array3));

            Array.Resize(ref array1, array1.Length + 3);
            Console.WriteLine(string.Join("＆ ", array1));

            Array.Clear(array2, 1, 2);
            Console.WriteLine(string.Join("＆ ", array2));

            var multi1 = new string[,] {
                { "ハ","ニ","ホ","へ","ト" }, { "ど","れ","み","ふぁ","そ" } };
            var multi2 = new string[2, 3];
            Array.Copy(multi1, 2, multi2, 0, 6);
            foreach (var v in multi2) { Console.WriteLine(v); }
        }
    }
}
