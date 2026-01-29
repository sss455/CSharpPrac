namespace SelfCSharp.Chap09
{
    internal class TryBad
    {
        static void Main(string[] args)
        {
            var data = new[] { "C#", "Java", "Python" };
            try
            {
                var i = 0;
                while (true)
                {
                    Console.WriteLine(data[i++]);
                }
            }
            catch (IndexOutOfRangeException ex) { }
        }
    }
}
