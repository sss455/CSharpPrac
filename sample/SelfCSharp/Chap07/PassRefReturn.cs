namespace SelfCSharp.Chap07
{
    internal class PassRefReturn
    {
        public ref int ReturnRef(int[] data)
        {
            return ref data[0];
        }

        static void Main(string[] args)
        {
            var data = new[] { 1, 2, 3 };
            var p = new PassRefReturn();
            ref int num = ref p.ReturnRef(data);
            //int num = p.ReturnRef(data);
            num = 10;
            Console.WriteLine(num);
            Console.WriteLine(data[0]);
        }
    }
}
