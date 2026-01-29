namespace SelfCSharp.Chap08.Practice
{
    internal class MyClass
    {
        protected double value;

        public MyClass(double value)
        {
            this.value = value;
        }

        public virtual string GetValue()
        {
            return this.value.ToString("F1");
        }
    }

    internal class MySubClass : MyClass
    {
        public MySubClass(double value) : base(value) { }

        public override string GetValue()
        {
            return $"［{base.GetValue()}］";
        }
    }
    internal class Practice4
    {
        static void Main(string[] args)
        {
            var ms = new MySubClass(0.56);
            Console.WriteLine(ms.GetValue());

            var m = new MyClass(0.56);
            Console.WriteLine(m.GetValue());
        }
    }
}
