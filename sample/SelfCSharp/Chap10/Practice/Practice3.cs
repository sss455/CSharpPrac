namespace SelfCSharp.Chap10.Practice
{
    internal class Practice3
    {
        public static T[] Grep<T>(T[] data, Predicate<T> condition)
        {
            var result = new List<T>();
            foreach (var value in data)
            {
                if (condition(value))
                {
                    result.Add(value);
                }
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            var data = new[] { 1, 2, 7, 10, 15, 19 };
            var result = Grep(data, v => v % 2 == 0);
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }
    }
}
