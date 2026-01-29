namespace SelfCSharp.Chap07.Practice
{
    internal class PCalculation
    {
        public static double GetAverage(params double[] values)
        {
            var result = 0.0;
            foreach (var v in values)
            {
                result += v;
            }
            return result / values.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PCalculation.GetAverage(100, 80, 65));
        }
    }
}
