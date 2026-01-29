namespace SelfCSharp.Chap11
{
    internal class EventBasic
    {
        static void Main(string[] args)
        {
            var ev = new MyEvent();
            ev.KeyCommand += OnKeyCommand;
            //ev.KeyCommand -= OnKeyCommand;
            ev.Run();
        }

        static void OnKeyCommand(string data)
        {
            switch (data.ToLower())
            {
                case "c":
                    Console.WriteLine($"現在の日時は{DateTime.Now}");
                    break;
                case "x":
                    var r = new Random();
                    Console.WriteLine($"乱数は{r.Next()}");
                    break;
                case "h":
                    Console.WriteLine("何も入力せずに確定で終了します。");
                    break;
                default:
                    Console.WriteLine("認識できないコマンドです");
                    break;
            };
        }
    }
}
