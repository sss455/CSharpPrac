namespace SelfCSharp.Chap09
{
    [Flags]
    enum FontStyle
    {
        Bold = 1,
        Italic = 2,
        Underline = 4,
        All = (Bold | Italic | Underline),
        //NonBold = (Italic | Underline),
    }

    internal class EnumBit
    {
        static void Main(string[] args)
        {
            var styles = FontStyle.Bold | FontStyle.Italic;

            if (styles.HasFlag(FontStyle.Bold))
            {
                Console.WriteLine("太字指定されています。");
            }

            if (styles.HasFlag(FontStyle.Bold | FontStyle.Italic))
            {
                Console.WriteLine("太字＆斜体指定されています。");
            }

            Console.WriteLine(styles);
        }
    }
}
