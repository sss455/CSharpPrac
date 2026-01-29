namespace SelfCSharp.Chap08
{
    internal class Pet
    {
        public string Name { get; init; }

        public Pet(string name = "")
        {
            this.Name = name;
        }
    }

    internal class PropInit
    {
        static void Main(string[] args)
        {
            var p1 = new Pet("のどか");
            Console.WriteLine(p1.Name);

            var p2 = new Pet
            {
                Name = "まめ"
            };
            Console.WriteLine(p2.Name);
        }
    }
}
