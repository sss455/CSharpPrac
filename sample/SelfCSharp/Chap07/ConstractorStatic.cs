namespace SelfCSharp.Chap07.Construct
{
    internal class Message
    {
        int number;

        static Message()
        {
            Console.WriteLine("静的コンストラクター");
        }

        public Message(int number)
        {
            this.number = number;
            Console.WriteLine($"通常のコンストラクター{number}");
        }
    }
    internal class ConstractorStatic
    {
        static void Main(string[] args)
        {
            var m1 = new Message(1);
            var m2 = new Message(2);
        }
    }
}
