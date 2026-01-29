using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08.Abstract
{
    // 抽象クラス（abstruct)
    internal abstract class Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // コンストラクタ
        public Figure(double width, double height)
        {
            this.Width = width; 
            this.Height = height; 
        }

        // 抽象メソッド（abstruct)
        public abstract double GetArea();

        // 通常のメソッドも定義可能
        public double calcSquareArea(double width, double height)
        {
            return width * height;
        }
    }
}
