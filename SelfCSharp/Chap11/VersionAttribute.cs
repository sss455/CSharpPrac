using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap11
{
    // AttributeUsage属性を付与して、この属性クラスを適用可能な場所を宣言
    [AttributeUsage(AttributeTargets.Class |      // クラス
                    AttributeTargets.Interface |  // インターフェイス
                    AttributeTargets.Struct,      // 構造体
                    Inherited = false)]           // 名前付きパラメータ（Inherited＝属性を派生クラスにも反映させるか）
    internal class VersionAttribute : Attribute
    {
        // 属性として管理する情報（プロパティ）
        public string Number { get; }           // バージョン番号
        public bool Beta { get; set; } = false; // β版であるか（デフォルトfalse）

        // Numberプロパティを初期化（コンストラクタ―）
        public VersionAttribute(string number) 
        { 
            this.Number = number; 
        }

    }
}
