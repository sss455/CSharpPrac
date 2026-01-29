namespace SelfCSharp.Chap08.Accessor
{
    internal class Triangle
    {
        private double width;
        private double height;

        public double GetWidth()
        {
            return this.width;
        }

        public void SetWidth(double width)
        {
            if (width <= 0)
            {
                throw new ArgumentException("正数で指定してください。");
            }
            this.width = width;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("正数で指定してください。");
            }
            this.height = height;
        }

        public double GetArea()
        {
            return GetWidth() * GetHeight() / 2;
        }
    }

    internal class PropAccess
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.SetWidth(10);
            t.SetHeight(5);
            Console.WriteLine($"三角形の面積は{t.GetArea()}です。");
            t.SetWidth(-5);
        }
    }
}
