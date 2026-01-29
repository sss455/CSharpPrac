using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap11
{
    // デリゲートを準備
    delegate void KeyCommandEventHandler(String data);

    internal class MyEvent
    {
        // イベントを準備（MyEventクラスのイベントとして登録）
        public event KeyCommandEventHandler KeyCommand = v => { };

        public void Run()
        {
            Console.WriteLine("コマンドを入力してください。");
            Console.WriteLine("c：現在時刻を表示、x：乱数表示、h：ヘルプ");

            // 無限ループ（繰り返しコマンド入力を求める）
            while(true)
            {
                // ユーザーからの入力を要求
                Console.Write("コマンド：");
                var input = Console.ReadLine();

                // 入力が空の場合はループを終了
                if(input == null || input == "")
                {
                    break;
                }

                // KeyCommandイベントを発生
                KeyCommand(input);
            }
        }
    }
}
