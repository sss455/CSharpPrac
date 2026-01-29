namespace SelfCSharp.Chap09
{
    struct MutableValue
    {
        public string Name { get; set; }

        public MutableValue()
        {
            this.Name = "名無権兵衛";
        }

        public void Update(string name)

        //public readonly void Update(string name)
        {
            this.Name = name;
            Console.WriteLine("Update method is finished!!");
        }

        //public readonly void Update(string name)
        //{
        //    UpdateNest(name);
        //}

        public void UpdateNest(string name)
        {
            this.Name = name;
        }
    }

    internal class ReadonlyNotation
    {
        static readonly MutableValue mv = new();
        static void Main(string[] args)
        {
            //mv.Name = "佐藤理央";
            mv.Update("佐藤理央");
            Console.WriteLine(mv.Name);
        }
    }

}
