using IronPython.Hosting;
using System;

namespace SelfCSharp.Chap11
{
    internal class PythonCall
    {
        static void Main(string[] args)
        {
            var py = Python.CreateRuntime();                    // 実行エンジンの生成（CreateRuntimeメソッド）
            dynamic script = py.UseFile("Chap11/myClass.py");   // スクリプトファイルの読み込み（UseFileメソッド）
            dynamic clazz = script.MyClass();                   // Pythonで定義されたMyClassクラスをインスタンス化
            Console.WriteLine(clazz.greet("山田"));             // MyClassクラスのgreetメソッドを呼び出し

            // hello.pyを直接実行
            py.UseFile("Chap11/hello.py");
        }
    }
}
