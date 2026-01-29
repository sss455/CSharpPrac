using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08.Implement
{
    internal interface IMyFigure
    {
        // 省略しても無条件に「public abstract」とみなされる
        int Hoge1 { get; set; }
        public abstract int Hoge2 { get; set; }

        // 抽象メソッド
        double GetArea();
        // p.415 「abstract」を付けるとコンパイルエラーになるのでは？？
        public abstract double GetArea2();
    }
}
