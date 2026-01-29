namespace SelfCSharp.Chap07.Practice
{
    internal class Hamster
    {
        readonly string name;
        readonly int age;

        public Hamster(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Hamster() : this("権兵衛", 0) { }

        public string Show(string format = "{0}は{1}歳です！")
        {
            return String.Format(format, this.name, this.age);
        }
    }

    internal class Practice3
    {
        static void Main(string[] args)
        {
            var h = new Hamster();
            Console.WriteLine(h.Show());
        }
    }
}
