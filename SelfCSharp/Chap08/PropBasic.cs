using System;

namespace SelfCSharp.Chap08
{
    internal class Triangle
    {
        // フィールドは private権限で定義
        private double _width;
        private double _height;

        // Widthのプロパティ
        public double Width
        {
            set
            {
                // 指定値が負数の場合
                if(value <= 0)
                {
                    throw new ArgumentException("正数で指定してください。");
                }
                _width = value;
            }

            get { return _width; }

        }

        // Heightのプロパティ
        public double Height
        {
            set
            {
                // 指定値が負数の場合
                if (value <= 0)
                {
                    throw new ArgumentException("正数で指定してください。");
                }
                _height = value;
            }

            get { return _height; }

        }

        public double getArea()
        {
            return Width * Height / 2;
        }
    }


    internal class PropBasic
    {
        static void Main(string[] args)
        {
            var t = new Triangle();

            // プロパティの設定
            t.Width = 10;
            t.Height = 5;

            // プロパティの参照
            Console.WriteLine($"幅{ t.Width }、高さ{ t.Height } の三角形の面積は、{t.getArea()} です。");
            // → 結果：「幅10、高さ5 の三角形の面積は、25 です。」

            t.Width = -5;
            // → エラー「Unhandled exception. System.ArgumentException: 正数で指定してください。」
        }
    }
}
