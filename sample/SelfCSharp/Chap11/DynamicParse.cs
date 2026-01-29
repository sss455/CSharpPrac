using Newtonsoft.Json;

namespace SelfCSharp.Chap11
{
    internal class DynamicParse
    {
        static void Main(string[] args)
        {
            dynamic json = JsonConvert.DeserializeObject(
                @"{
                    ""title"":""速習C#"",
                    ""min-price"":1000, 
                    ""sample"":{""dl"":true},
                    ""authors"":[""山田太郎"", ""鈴木次郎""]
                }")!;
            Console.WriteLine(json.title);
            Console.WriteLine(json.sample.dl);
            Console.WriteLine(json.authors[1]);
            Console.WriteLine(json["min-price"]);
        }
    }
}
