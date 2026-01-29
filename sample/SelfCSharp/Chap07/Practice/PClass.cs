namespace SelfCSharp.Chap07.Practice
{
    internal class PClass
    {
        int data = 10;

        void Hoge(int data)
        {
            if (data < 0)
            {
                data = 0;
            }
            Console.WriteLine(data);
        }

        static void Main(string[] args)
        {
            var m = new PClass();
            m.Hoge(13);
            m.Hoge(-13);
            Console.WriteLine(m.data);
        }
    }
}
