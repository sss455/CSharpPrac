using System;

namespace SelfCSharp.Chap08
{
    internal class Person
    {
        public string FirstName { get; set; } = "花子";
        public string LastName { get; set; } = "田中";

        // get／set単位のアクセス修飾子
        public string City { get; private set; } = "岡山市";
        // Get-Only自動プロパティ                                                                                               
        public string Phone { get; } = "086-xxx-xxxx";
        // Init-Onlyプロパティ
        public string Email { get; init; } = "sample@test.com";

        public string Show()
        {
            this.City = "倉敷市";

            return $"名前は、{this.LastName} {this.FirstName} です。\n" +
                   $"{this.City}に住んでいて、電話番号は{this.Phone}、メールアドレスは{this.Email}です。";
        }
    }


    internal class PropAuto
    {
        static void Main(string[] args)
        {
            // オブジェクト初期化子
            var p = new Person()
            {
                FirstName = "太郎",
                LastName  = "山田",
                //City      = "倉敷市",        // private set
                //Phone = "086-yyy-yyyy",      // Get-Onlyプロパティ（コンパイルエラー）
                Email = "sample2@test.com",    // Init-Onlyプロパティ
            };
            Console.WriteLine(p.Show());

            //p.Email = "sample3@test.com";
        }
    }
}
