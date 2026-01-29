namespace SelfCSharp.Chap07.MethodArgs
{
    internal class ArgsParamsGood
    {
        public int TotalProducts(int initial, params int[] values)
        {
            int result = initial;
            foreach (var value in values)
            {
                result *= value;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var v = new ArgsParamsGood();
            Console.WriteLine(v.TotalProducts(12, 15, -1));
            Console.WriteLine(v.TotalProducts(5, 7, 8, 2));
        }
    }
}
