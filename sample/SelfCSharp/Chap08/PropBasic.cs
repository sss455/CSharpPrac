namespace SelfCSharp.Chap08.Prop
{
    internal class Triangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("正数で指定してください。");
                }
                this._width = value;
            }

            get { return this._width; }
        }

        public double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("正数で指定してください。");
                }
                this._height = value;
            }

            get { return this._height; }
        }

        public double GetArea()
        {
            return Width * Height / 2;
        }
    }

    internal class PropBasic
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.Width = 10;
            t.Height = 5;
            Console.WriteLine($"三角形の面積は{t.GetArea()}です。");
            t.Width = -5;
        }
    }
}