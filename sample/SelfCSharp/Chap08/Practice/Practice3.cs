namespace SelfCSharp.Chap08.Practice
{
    internal class Animal
    {
        private int _age;

        public string Name { get; private set; }

        public int Age
        {
            get { return _age; }
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Intro()
        {
            Console.WriteLine($"ボクの名前は{this.Name}。{this.Age}歳だよ");
        }
    }

    internal class Practice3
    {
        static void Main(string[] args)
        {
            var a = new Animal("サクラ", 1);
            a.Intro();
        }
    }
}
