namespace SelfCSharp.Chap05
{
    internal class StreamWrite
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"c:\data\data.log"))

            //using (var writer = new StreamWriter(@"c:\data\data.log", true))

            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //using (var writer = new StreamWriter(@"c:\data\data.log", true,
            //    Encoding.GetEncoding("Shift-JIS")))

            //名前付き引数を使った場合
            //using (var writer = new StreamWriter(@"c:\data\data.log", append: true))

            {
                writer.WriteLine(DateTime.Now.ToString());

                //Writeメソッドで書き換えた場合
                //writer.Write(DateTime.Now.ToString() + "\r\n");
            }
        }
    }
}
