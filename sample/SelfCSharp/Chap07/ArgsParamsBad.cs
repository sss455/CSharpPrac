namespace SelfCSharp.Chap07.MethodArgs
{
    internal class ArgsParamsBad
    {
        public int TotalProducts(params int[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentNullException();
            }
            int result = 1;
            foreach (var value in values)
            {
                result *= value;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var v = new ArgsParamsBad();
            Console.WriteLine(v.TotalProducts(12, 15, -1));
            Console.WriteLine(v.TotalProducts(5, 7, 8, 2));
        }
    }
}
