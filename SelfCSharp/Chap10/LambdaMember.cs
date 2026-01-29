using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10
{
    internal class LambdaMember
    {
        //########################################################################
        //
        // C# 6以降では、以下のメンバーをラムダ式の　形式で定義できるように。
        //
        //########################################################################

        private int _value;

        //---------------------------------------------------
        // コンストラクター
        //---------------------------------------------------
        LambdaMember() => Console.Write("コンストラクター");

        //---------------------------------------------------
        // プロパティ（C# 7以降）
        //---------------------------------------------------
        public int Value
        {
            get => this._value;
            set => this._value = value;
        }

        //---------------------------------------------------
        // get-onlyプロパティ（C＃ 6ではこちらだけ）
        //---------------------------------------------------
        public DateTime Current => DateTime.Now;

        //---------------------------------------------------
        // インデクサー
        //---------------------------------------------------
        public int this[int index] => this.Value * index;

        //---------------------------------------------------
        // メソッド
        //---------------------------------------------------
        public int Calculate() => this.Value * this.Value;

        //---------------------------------------------------
        // 演算子
        //---------------------------------------------------
        public static bool operator true(LambdaMember e) => e.Value == 0;
        public static bool operator false(LambdaMember e) => e.Value != 0;
    }
}
