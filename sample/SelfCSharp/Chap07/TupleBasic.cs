namespace SelfCSharp.Chap07
{
    internal class TupleBasic
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
            //return x >= y ? (max: x, min: y) : (max: y, min: x);
        }

        static void Main(string[] args)
        {
            var a = new TupleBasic();
            var t = a.GetMaxMin(15, 13);
            //(int max, int min) t = a.GetMaxMin(15, 13);
            //(int min, int max) t = a.GetMaxMin(15, 13);
            Console.WriteLine(t.max);
            Console.WriteLine(t.min);


            //(int upper, int lower) t = a.GetMaxMin(15, 13);
            //Console.WriteLine(t.upper);
            //Console.WriteLine(t.lower);

            //(double upper, double lower) t = a.GetMaxMin(15, 13);
            //Console.WriteLine(t.upper);
            //Console.WriteLine(t.lower);

            var (resultMax, resultMin) = a.GetMaxMin(5, 3);
            //(var resultMax, var resultMin) = a.GetMaxMin(5, 3);
            //(int resultMax, int resultMin) = a.GetMaxMin(5, 3);
            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
        }
    }
}
