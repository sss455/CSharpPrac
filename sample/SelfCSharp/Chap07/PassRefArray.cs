namespace SelfCSharp.Chap07
{
    internal class PassRefArray
    {
        public int[] Update(ref int[] data)
        {
            data[0] = 5;

            //配列そのものを置き換えた場合
            //data = new[] { 10, 20, 30 };
            return data;
        }

        static void Main(string[] args)
        {
            var data = new[] { 2, 4, 6 };
            var p = new PassRefArray();
            Console.WriteLine(p.Update(ref data)[0]);
            Console.WriteLine(data[0]);
        }
    }
}

