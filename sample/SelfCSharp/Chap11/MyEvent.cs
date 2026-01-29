namespace SelfCSharp.Chap11
{
    delegate void KeyCommandEventHandler(string data);

    internal class MyEvent
    {
        public event KeyCommandEventHandler KeyCommand = v => { };

        public void Run()
        {
            Console.WriteLine("コマンドを入力してください。");
            Console.WriteLine("c：現在時刻を表示、x：乱数表示、h：ヘルプ");
            while (true)
            {
                Console.Write("コマンド：");
                var input = Console.ReadLine();
                if (input == null || input == "")
                {
                    break;
                }
                KeyCommand(input);
            }
        }
    }
}
