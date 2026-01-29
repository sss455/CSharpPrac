namespace SelfCSharp.Chap07
{
    internal class PassBasic
    {
        public int CountUp(int data)
        {
            data++;
            return data;
        }

        static void Main(string[] args)
        {
            var data = 1;
            var p = new PassBasic();
            Console.WriteLine(p.CountUp(data));
            Console.WriteLine(data);
        }
    }
}
