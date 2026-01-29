namespace SelfCSharp.Chap03
{
    internal class NameOfNull
    {
        public void Hoge(string? str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str");
                //throw new ArgumentNullException(nameof(str));
            }
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            var nc = new NameOfNull();
            nc.Hoge(null);
        }
    }
}
